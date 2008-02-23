using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count <= (item ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public double Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every context account entry stays within the limit.</summary>
        public static bool CheckContextAccountRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many record graph samples are out of range.</summary>
        public static long TallyRecordGraphHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) != (bound / 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 74.73;
        public const long SoftDepth = 5310;
        public const long SoftRatio = 2236;
        public const long BatchRatio = 9026;
        public const double SoftScore = 82.73;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }
    }
}
