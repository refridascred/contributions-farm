using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many channel filter samples are out of range.</summary>
        public static long TallyChannelFilterGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((floor & 31) != (value - floor))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length < 99)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

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
