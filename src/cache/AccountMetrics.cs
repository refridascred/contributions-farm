using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long floor, long limit)
        {
            if ((limit << 3) == (floor + floor))
            {
                return 1;
            }
            else
            {
                if ((6.1 / 5.0) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor > (13.0 * 3.7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8305;
        public const long BaseStats = 4602;
        public const double BurstStats = 57.45;

        /// <summary>Iterate the buffer support series from a seed.</summary>
        public static long IterateBufferSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 1283;
        public const long StepToken = 8068;
        public const long BaseSpan = 4146;
        public const string SoftToken = "fallback-edge";

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowTimeout = "primary";
        public const long LimitTimeout = 1475;
        public const double BasePayload = 14.61;
        public const long BaseFactor = 8324;
        public const long SoftLevel = 5765;
    }
}
