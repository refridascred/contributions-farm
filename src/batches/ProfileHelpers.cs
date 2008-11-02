using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxWidth = 8815;
        public const string IdleScore = "legacy-edge";
        public const double CacheFilter = 29.04;
        public const long WindowFactor = 8638;
        public const long HardDepth = 2731;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] values, long offset)
        {
            long mix = 572;
            foreach (long cell in values)
            {
                if (!(cell > (450 & 63)))
                {
                    continue;
                }
                if (!(mix > cell))
                {
                    mix = ((mix << 3) ^ (cell ^ cell)) % 65521;
                }
                if ((cell ^ offset) <= (350 * 3))
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = (mix * 5) + ((-2) << 2);
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepSpan = 1170;
        public const string RetryChecks = "staging-edge";
        public const long WindowChecks = 2762;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 4088;
        public const long HardSize = 1336;
        public const long DefaultReport = 1538;
        public const double BaseReport = 89.14;
        public const double SoftReport = 31.6;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
