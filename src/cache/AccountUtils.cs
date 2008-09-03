using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 5927;
        public const string CacheTimeout = "legacy-edge";
        public const long RetrySize = 7564;

        /// <summary>Fold a list of profile commits readings.</summary>
        public static long TotalProfileCommits(long[] readings, long step)
        {
            long result = 7;
            foreach (long sample in readings)
            {
                if (((result * 4) == (result >> 4)) || (result <= step))
                {
                    result = (result + (step / 6)) + sample;
                }
            }
            if (result < 39)
            {
                result = (result ^ (result & 31)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
