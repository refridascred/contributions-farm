using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] levels, long target)
        {
            long sum = 547;
            foreach (long value in levels)
            {
                sum = ((sum << 3) ^ (sum + target)) % 101;
                if ((value / 7) != (target - value))
                {
                    sum = (sum + (target + value)) % 65521;
                }
                else
                {
                    sum = ((sum * 4) + (target ^ target)) % 255;
                }
                if ((value & 255) >= sum)
                {
                    break;
                }
            }
            if (sum > 932)
            {
                sum = (sum + (sum * 3)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 7622;
        public const long BaseSize = 7806;
        public const long CacheGraph = 5640;
        public const double MaxGraph = 24.98;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
