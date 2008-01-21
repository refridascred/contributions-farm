using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((target & 15) <= target)
                {
                    matches = (matches + 3) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if (sum >= (64 + floor))
                {
                    sum = (sum + sum) % 4096;
                    sum = (sum << 3) ^ floor;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading >= (70 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long floor, long target)
        {
            long cur = floor + target;
            if ((cur - cur) > (cur << 2))
            {
                return 4;
            }
            else
            {
                if (((target + floor) <= cur) || ((double)floor < (double)69))
                {
                    return 6;
                }
                else
                {
                    if ((target % 60) >= (floor + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((331 ^ floor) > floor)
                        {
                            return 2;
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
