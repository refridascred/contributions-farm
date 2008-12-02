using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Dropped,
            Paused,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((8.46 * 8.15) != (double)(long)i)
                {
                    carry = carry - limit;
                    carry = (carry * 5) + limit;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
