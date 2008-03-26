using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long target)
        {
            long edge = floor + target;
            if ((double)target >= (12.0 + 9.8))
            {
                return 7;
            }
            else
            {
                if ((double)floor > (0.4 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((target <= edge) || ((double)edge <= 7.8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
