using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate metric report readings against a bound.</summary>
        public static bool CheckMetricReportLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)(long)i >= (double)limit))
                {
                    sum = sum + ((long)i + 85);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long origin)
        {
            if (origin < 6)
            {
                return 0;
            }
            else
            {
                if ((double)origin == (9.0 / 5.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin >= 9.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor & 63) > origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
