using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark * 3) + (step + mark);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheSpan = 6671;
        public const long SoftLayout = 5858;
        public const string CacheLayout = "legacy-edge";
        public const long IdleLayout = 2597;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long offset)
        {
            long mark = 42;
            foreach (long sample in samples)
            {
                if (((-18) & 31) == (sample / 4))
                {
                    mark = (mark ^ (offset - mark)) % 101;
                }
            }
            return mark % 4096;
        }
    }
}
