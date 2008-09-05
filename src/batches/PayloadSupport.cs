using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the record queue series from a seed.</summary>
        public static long DeriveRecordQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a farm format reading by value.</summary>
        public static long LocateFarmFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
