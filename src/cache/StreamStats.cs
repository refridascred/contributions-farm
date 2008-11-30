using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Dropped,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values)
        {
            long total = 375;
            foreach (long datum in values)
            {
                if ((datum + 3) < (total + (long)values.Length))
                {
                    total = (total ^ datum) % 65521;
                }
                else
                {
                    total = ((total * 5) + 804) % 101;
                }
            }
            if (total > 712)
            {
                total = total - (total & 31);
            }
            return total;
        }
    }
}
