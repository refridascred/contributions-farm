using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double gain, double span)
        {
            double mean = 7.58;
            return (mean + (mean - gain)) + span;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count >= (7.9 * 5.2))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
