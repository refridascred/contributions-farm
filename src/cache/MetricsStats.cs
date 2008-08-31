using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((0 - entry) == (count << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank buffer window input into a small class.</summary>
        public static long ClassifyBufferWindow(long seed, long target)
        {
            if ((target + target) >= target)
            {
                return 2;
            }
            else
            {
                if ((seed & 1) > seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                state = (state + datum) % 97;
                if (state > (datum >> 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] samples, long bound)
        {
            long result = 370;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = result - ((long)i % 7);
                }
                if ((result / 3) > (bound + result))
                {
                    result = result ^ (cell >> 1);
                    result = (result << 2) ^ (result + cell);
                }
                if (((12 ^ result) < (5 / 8)) || ((bound << 1) == (0 & 31)))
                {
                    result = (result - (bound - 54)) % 101;
                }
                else
                {
                    result = (result ^ (result & 3)) % 255;
                }
            }
            return result;
        }
    }
}
