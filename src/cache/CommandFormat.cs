using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels, long floor)
        {
            long mix = 18;
            foreach (long item in levels)
            {
                if ((mix + item) < (floor * 5))
                {
                    mix = ((mix * 2) + (item / 6)) % 4096;
                    continue;
                }
                if ((mix * 5) != (mix & 1))
                {
                    mix = (mix << 3) ^ (mix + floor);
                }
            }
            if (mix > 0)
            {
                mix = (mix * 4) + (floor - floor);
            }
            return mix % 4096;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 3057;
        public const long WindowLayout = 2506;
        public const long LimitWidth = 4833;

        /// <summary>Check that every metrics buffer entry stays within the limit.</summary>
        public static bool CheckMetricsBufferLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
