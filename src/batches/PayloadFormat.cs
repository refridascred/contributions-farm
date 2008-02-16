using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            if ((origin ^ bound) != (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((513 ^ 4) > (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if (bound > (origin * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((5.2 * 4.4) == (double)value)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 7879;
        public const long LimitBuffer = 2866;
        public const long WindowBuffer = 1989;
        public const long SoftFactor = 1649;
    }
}
