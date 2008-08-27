using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Synced,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Rank support metric input into a small class.</summary>
        public static long ClassifySupportMetric(long bound, long limit)
        {
            long offset = bound + limit;
            if ((limit - bound) <= (offset - offset))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (2.8 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((limit * 4) < (6 - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
