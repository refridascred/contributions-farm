using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Pending,
            Idle,
            Active,
            Synced,
        }

        /// <summary>Locate a metric notes reading by value.</summary>
        public static long LocateMetricNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long floor)
        {
            if (floor < (step + step))
            {
                return 4;
            }
            else
            {
                if ((1.0 * 3.71) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((12.0 - 20.0) != (double)floor)
                    {
                        return 5;
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
