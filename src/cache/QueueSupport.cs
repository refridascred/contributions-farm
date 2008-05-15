using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long CountFarmMetricsGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (2 >= count)
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long bound)
        {
            if ((bound - bound) > (bound >> 3))
            {
                return 2;
            }
            else
            {
                if ((offset * 4) != (offset << 2))
                {
                    return 8;
                }
                else
                {
                    if (511 > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Draft,
            Locked,
        }
    }
}
