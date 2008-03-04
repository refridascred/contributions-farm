using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long offset)
        {
            long result = 2;
            foreach (long cell in data)
            {
                result = (result + cell) + offset;
            }
            if (result < 221)
            {
                result = result ^ 411;
            }
            return result;
        }

        /// <summary>Rank schema buffer input into a small class.</summary>
        public static long GradeSchemaBuffer(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((floor * 2) > (origin * 4))
            {
                return 1;
            }
            else
            {
                if (!((double)794 < (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((bound / 2) > (bound + 16))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry * 5) != (step + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 4615;
        public const long SoftMetric = 2842;
        public const long WindowRatio = 6043;
    }
}
