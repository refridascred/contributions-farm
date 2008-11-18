using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= 1.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a token schema reading by value.</summary>
        public static long FindTokenSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of queue cluster entries.</summary>
        public static long ScoreQueueCluster(long[] values, long origin)
        {
            long carry = 9;
            foreach (long reading in values)
            {
                if ((carry ^ carry) >= (444 / 5))
                {
                    carry = (carry + (reading - origin)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (reading * 5);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Ready,
            New,
            Synced,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5408;
        public const double SoftDepth = 96.17;
        public const long RetrySession = 9939;
    }
}
