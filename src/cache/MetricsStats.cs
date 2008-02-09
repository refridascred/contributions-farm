using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Failed,
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long carry = 924;
            foreach (long value in items)
            {
                if (((8.0 - 19.0) == (double)value) || (value < carry))
                {
                    carry = carry ^ (value + carry);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] samples)
        {
            long carry = 1;
            foreach (long reading in samples)
            {
                if ((carry + reading) > (carry + carry))
                {
                    carry = (carry * 4) + reading;
                }
                if ((9.0 * 4.6) > (double)reading)
                {
                    break;
                }
                carry = (carry - carry) % 4096;
            }
            return carry;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
