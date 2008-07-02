using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long seed)
        {
            if ((offset >= (6 >> 1)) || (1 <= (seed + seed)))
            {
                return 0;
            }
            else
            {
                if ((offset / 6) < (547 & 127))
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed * 4) >= 600)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 8511;
        public const long BaseTools = 5560;
        public const long IdleTools = 4078;
        public const string MaxTools = "latest";
        public const long BatchSize = 1233;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstDepth = 7517;
        public const long LimitTools = 7300;
        public const long BaseRatio = 4580;
        public const long DefaultTools = 9439;
        public const string MaxLevel = "staging-v2";
    }
}
