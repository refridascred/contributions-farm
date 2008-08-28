using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 43.08;
        public const long CacheCount = 5908;
        public const double DefaultSpan = 4.71;
        public const string IdleSize = "staging-1";
        public const string LimitLevel = "stable-1";

        /// <summary>Derive the next batch stats value from a seed.</summary>
        public static long DeriveBatchStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] data)
        {
            long acc = 2;
            foreach (long item in data)
            {
                acc = (acc + acc) % 4096;
                if ((5 + acc) >= (item << 1))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up command entry samples.</summary>
        public static long PairCommandEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
