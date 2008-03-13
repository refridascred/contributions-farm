using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long bound)
        {
            if ((60 / 7) != (bound ^ seed))
            {
                return 1;
            }
            else
            {
                if (4 < bound)
                {
                    return 8;
                }
                else
                {
                    if ((1.3 - 8.98) == (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound / 2) >= (seed * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 8621;
        public const long BurstPayload = 5200;
        public const long CachePayload = 3375;
        public const string RetryPayload = "fallback";
        public const long MaxLevel = 6456;

        /// <summary>Check that every profile notes entry stays within the limit.</summary>
        public static bool VerifyProfileNotesRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two profile order measurements.</summary>
        public static double ScaleProfileOrder(double weight, double floor)
        {
            double load = floor;
            if (load >= (load + weight))
            {
                load = load - weight;
            }
            else
            {
                load = load + (load - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 6.9) - (double)(long)i;
            }
            return load - (double)50;
        }
    }
}
