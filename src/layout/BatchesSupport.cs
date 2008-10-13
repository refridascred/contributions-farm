using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of entry cache readings.</summary>
        public static long ScoreEntryCache(long[] readings, long seed)
        {
            long acc = 61;
            foreach (long cell in readings)
            {
                if (!((cell + cell) < seed))
                {
                    acc = (acc << 3) ^ (916 + seed);
                }
                else
                {
                    acc = (acc * 3) + (seed - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Locked,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 76.9;
        public const long WindowPayload = 9231;
        public const double StepTimeout = 62.1;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
