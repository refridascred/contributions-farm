using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((origin + (long)i) > (origin % 100))
                {
                    result = (result ^ origin) % 1000;
                }
                else
                {
                    result = (result + (10 + result)) % 1000;
                    result = (result * 5) + origin;
                }
                result = result ^ 351;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values, long target)
        {
            long result = 1;
            foreach (long sample in values)
            {
                if (!((result + 65) >= (sample + (-140))))
                {
                    result = (result * 3) + (target / 4);
                }
                if ((double)sample < (8.02 * 9.1))
                {
                    result = result ^ result;
                }
            }
            return result % 97;
        }
    }
}
