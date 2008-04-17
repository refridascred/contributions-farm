using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] readings)
        {
            long total = 48;
            foreach (long sample in readings)
            {
                total = ((total + total) % 101) + sample;
            }
            if (total > 930)
            {
                total = (total ^ (total << 3)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double scale, double span)
        {
            double scale2 = span - (scale * 12.0);
            if (scale2 >= (double)(-37))
            {
                scale2 = scale2 + (span / 9.0);
            }
            return scale2 + (4.3 - span);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (2.1 <= (double)tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches <= (sample << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen <= (value ^ 281))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
