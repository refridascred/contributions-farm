using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 3) ^ (bound * 3)) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] samples)
        {
            long score = 2;
            foreach (long item in samples)
            {
                score = ((score * 4) + (1 << 3)) ^ item;
            }
            return score % 65521;
        }
    }
}
