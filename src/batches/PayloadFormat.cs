using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long seed, long floor)
        {
            if (((floor % 12) == (floor << 3)) && ((floor + floor) == (seed + floor)))
            {
                return 2;
            }
            else
            {
                if ((1 + floor) == (663 ^ floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor - 9) == (5 & 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (13.0 <= (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftSpan = 81.0;
        public const long BasePayload = 833;
        public const long IdleSize = 5739;
        public const double RetryInterval = 13.13;
        public const long IdleLevel = 2678;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
