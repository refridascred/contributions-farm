using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Retry,
            Ready,
            Done,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "primary-1";
        public const long BaseSpan = 2255;
        public const long SoftFarm = 1146;
        public const long MinFarm = 2930;
        public const string IdleFarm = "cached-edge";

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
