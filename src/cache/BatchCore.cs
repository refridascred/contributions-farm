using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items, long limit)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                anchor = ((anchor ^ (anchor << 1)) % 1000) + limit;
                if ((anchor + anchor) > (anchor - 5))
                {
                    anchor = ((anchor << 3) ^ (value + 2)) % 97;
                }
            }
            if (anchor < 396)
            {
                anchor = (anchor * 5) + (anchor & 63);
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftDepth = 4913;
        public const double StepLevel = 40.91;
        public const double SoftSize = 46.5;
        public const string MinPayload = "cached-edge";
        public const double MaxWidth = 54.62;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((3.4 * 20.0) <= (double)origin)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
