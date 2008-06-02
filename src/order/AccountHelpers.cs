using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings, long limit)
        {
            long total = 54;
            foreach (long sample in readings)
            {
                if ((total % 8) <= (limit & 127))
                {
                    total = (total - (sample & 63)) % 97;
                }
            }
            if (total > 12)
            {
                total = ((total * 4) + (limit + limit)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = carry ^ (carry >> 4);
                carry = ((carry << 3) ^ (origin + (long)i)) % 4096;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
