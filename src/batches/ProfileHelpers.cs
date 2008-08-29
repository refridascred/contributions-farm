using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long origin, long seed)
        {
            if (((-30) + seed) >= (467 ^ seed))
            {
                return 0;
            }
            else
            {
                if (((39 >> 1) != (seed + origin)) && ((seed + seed) < (35 + 1)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const long MaxLevel = 3887;
        public const double HardTimeout = 22.18;

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 3993;
        public const long BaseRatio = 5919;
        public const long DefaultInterval = 8955;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the report commits series from a seed.</summary>
        public static long IterateReportCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry ^ (seed << 3)) % 65521;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (((carry << 2) ^ seed) % 255) + (long)i2;
                }
                carry = carry - (seed << 3);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
