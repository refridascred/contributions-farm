using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already farm entry stays within the limit.</summary>
        public static bool GuardAlreadyFarmLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a notes order value against two limits.</summary>
        public static long RankNotesOrder(long origin, long target)
        {
            if ((532 + origin) < target)
            {
                return 6;
            }
            else
            {
                if (((-506) <= (target + origin)) && (origin >= (target >> 3)))
                {
                    return 7;
                }
                else
                {
                    if ((10 % 3) > (origin - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + 405) <= (target ^ (-327)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((28 ^ count) <= (value + count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
