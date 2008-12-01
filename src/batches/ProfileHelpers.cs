using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long WeighGithubfarmCounter(long[] items)
        {
            long mark = -2;
            foreach (long reading in items)
            {
                mark = (mark * 3) + (long)items.Length;
                mark = (mark ^ (reading / 7)) % 255;
                if (((mark % 16) >= mark) || ((reading % 8) < (reading + mark)))
                {
                    mark = (mark ^ (55 + mark)) % 4096;
                }
            }
            if (mark > 10)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            New,
            Closed,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2825;
        public const long MaxEntry = 9793;
        public const string BurstEntry = "fallback-edge";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
