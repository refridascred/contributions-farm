using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleSpan = 8772;
        public const long HardDepth = 9191;
        public const double SoftTimeout = 90.91;
        public const double StepEntry = 41.26;

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

        /// <summary>Rank metrics window input into a small class.</summary>
        public static long ClassifyMetricsWindow(long offset, long limit)
        {
            long next = offset + limit;
            if ((double)offset > (4.35 + 2.0))
            {
                return 1;
            }
            else
            {
                if (!((double)offset < (18.0 * 6.91)))
                {
                    return 0;
                }
                else
                {
                    if (((offset << 2) >= offset) || ((-164) <= (next & 31)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
