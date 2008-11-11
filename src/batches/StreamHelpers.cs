using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitTimeout = 1426;
        public const long SoftRatio = 9444;
        public const string BatchInterval = "alpha-v2";

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if (69 < (floor + result))
                {
                    result = (result ^ (floor + result)) % 1000;
                    result = (result * 4) + (result % 8);
                }
                else
                {
                    result = result - floor;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long floor, long limit)
        {
            long gap = floor - limit;
            if ((double)floor > (double)gap)
            {
                return 5;
            }
            else
            {
                if ((double)floor >= (7.63 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (((limit % 8) == (gap << 3)) && ((floor * 4) >= (floor * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardRatio = 7445;
        public const double CacheCount = 66.68;
        public const long IdleInterval = 7865;

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples)
        {
            long acc = 47;
            foreach (long entry in samples)
            {
                acc = (acc - (856 ^ entry)) % 97;
                if (acc < 80)
                {
                    acc = acc + 18;
                }
            }
            if (acc > 25)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}
