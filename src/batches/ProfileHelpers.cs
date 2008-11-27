using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 7365;
        public const long HardAlready = 1479;
        public const double StepAlready = 58.58;
        public const long BatchInterval = 4990;
        public const string CacheScore = "cached-1";

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double ratio, double offset)
        {
            double bias = 7.27;
            if (bias > (ratio - ratio))
            {
                bias = (bias - (bias * 1.3)) - offset;
            }
            else
            {
                bias = bias - 0.91;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias + (bias * 9.4);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((20.0 - 0.78) <= (double)tally)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank token queue input into a small class.</summary>
        public static long BucketTokenQueue(long origin, long offset)
        {
            long lane = origin + offset;
            if ((169 + origin) > offset)
            {
                return 6;
            }
            else
            {
                if ((origin & 127) <= lane)
                {
                    return 5;
                }
                else
                {
                    if (offset > (offset - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset >= (959 >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Done,
            Closed,
            Failed,
        }
    }
}
