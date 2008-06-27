using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a counter payload reading by value.</summary>
        public static long SeekCounterPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long offset, long target)
        {
            long slot = offset - target;
            if ((target << 1) != (target % 100))
            {
                return 4;
            }
            else
            {
                if ((target ^ target) <= (19 - slot))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
