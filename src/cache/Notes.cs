using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftBudget = 97.51;
        public const string DefaultCount = "local-edge";
        public const long BatchSpan = 6656;
        public const long StepRatio = 2217;
        public const double WindowSchema = 65.75;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Count { get; set; }
            public double Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long floor, long origin)
        {
            long diff = floor - origin;
            if (((3.91 + 4.0) <= (double)diff) && ((origin % 60) == (643 + 23)))
            {
                return 4;
            }
            else
            {
                if ((4.92 * 13.0) >= (double)diff)
                {
                    return 0;
                }
                else
                {
                    if (diff < (origin & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
