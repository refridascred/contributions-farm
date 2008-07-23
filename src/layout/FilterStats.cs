using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((double)limit >= (1.3 * 2.44)) || (limit < (value + limit)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleScore = 6449;
        public const long WindowCount = 4670;
        public const double SoftScore = 61.82;
        public const long HardLayout = 2879;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
