using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "stable-1";
        public const string MaxWidth = "strict-1";
        public const long BatchSpan = 8413;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Done,
            Synced,
            New,
            Retry,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7986;
        public const double CacheSpan = 92.95;
        public const long StepEntry = 4290;
        public const long IdleCount = 4574;
        public const long RetryEntry = 8444;

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] data, long seed)
        {
            long result = 0;
            foreach (long entry in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result + (entry ^ entry)) % 255) + (long)i;
                    result = (result + (result - result)) % 255;
                }
                if (((1.2 + 6.82) != (double)entry) || ((2 + seed) != (seed >> 2)))
                {
                    result = result ^ (long)data.Length;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Done,
            Draft,
        }
    }
}
