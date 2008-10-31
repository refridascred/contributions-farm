using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double load = floor;
            if (load < (double)804)
            {
                load = load - (floor + load);
            }
            else
            {
                load = load - 18.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load - (floor * 1.0);
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] samples)
        {
            long total = -56;
            foreach (long cell in samples)
            {
                total = (((total << 3) ^ (88 ^ total)) % 1000) + cell;
            }
            return total;
        }

        /// <summary>Audit notes command readings against a rule.</summary>
        public static long CountNotesCommandHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((limit & 63) > 58)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            New,
            Stale,
            Closed,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item >> 5) == (count * 2))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
