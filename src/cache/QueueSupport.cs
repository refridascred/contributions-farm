using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultFactor = "legacy-1";
        public const long StepLevel = 2755;
        public const long BurstFactor = 10;
        public const long SoftContext = 8923;
        public const long MaxContext = 8213;

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long floor)
        {
            long delta = limit + floor;
            if (((5.53 / 5.0) == (double)limit) && (limit <= (floor & 1)))
            {
                return 3;
            }
            else
            {
                if ((limit + 0) > (floor + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit / 5) != (delta + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + floor) != (limit ^ limit))
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
        }
    }
}
