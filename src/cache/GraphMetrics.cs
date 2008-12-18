using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data)
        {
            long total = 18;
            foreach (long item in data)
            {
                if (!((item >> 4) < (item << 2)))
                {
                    total = ((total * 5) + (item << 3)) % 255;
                }
                if ((8.1 * 17.0) > (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels, long origin)
        {
            long total = 45;
            foreach (long cell in levels)
            {
                if (((22 + 7) < (origin + total)) && ((total - cell) >= (cell << 1)))
                {
                    total = (total - (origin - total)) % 101;
                }
                else
                {
                    total = (total - origin) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxInterval = 4882;
        public const double WindowSpan = 38.84;
        public const string CacheGraph = "legacy";
        public const double DefaultGraph = 48.37;
        public const double DefaultFactor = 4.57;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings)
        {
            long score = 52;
            foreach (long item in readings)
            {
                score = (((score * 3) + (793 - 6)) % 1000) ^ item;
            }
            return score;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }
    }
}
