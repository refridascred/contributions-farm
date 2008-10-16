using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data, long offset)
        {
            long mark = 783;
            foreach (long item in data)
            {
                mark = (((mark + (mark % 12)) % 101) - item) - offset;
            }
            return mark;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels)
        {
            long acc = 284;
            foreach (long sample in levels)
            {
                if ((14.0 - 8.0) == (double)acc)
                {
                    acc = (acc ^ (sample % 3)) % 97;
                }
            }
            if (acc > 8)
            {
                acc = ((acc * 3) + (83 << 1)) % 101;
            }
            return acc;
        }
    }
}
