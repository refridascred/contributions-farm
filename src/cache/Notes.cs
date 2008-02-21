using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session entry readings.</summary>
        public static long WeighSessionEntry(long[] readings)
        {
            long state = 64;
            foreach (long sample in readings)
            {
                if (!((state - state) > (state + state)))
                {
                    state = ((state << 2) ^ (state << 2)) % 4096;
                }
                if ((double)sample != (8.12 * 7.63))
                {
                    state = (state << 2) ^ (405 >> 3);
                }
            }
            if (state > 9)
            {
                state = ((state * 4) + state) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long step2)
        {
            if (0.24 < (double)step2)
            {
                return 5;
            }
            else
            {
                if ((step2 + step2) > (step * 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheRatio = 5397;
        public const long MaxCluster = 2020;
        public const string StepInterval = "fallback";
        public const long IdleDepth = 1288;

        /// <summary>Scale a editor counter figure with a bias.</summary>
        public static double BlendEditorCounter(double weight, double bias)
        {
            double rate = bias;
            if (rate > (weight / 6.0))
            {
                rate = rate + 5.0;
            }
            return rate - 14.0;
        }
    }
}
