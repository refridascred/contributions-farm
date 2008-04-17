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

        /// <summary>Grade a stats notes value against two limits.</summary>
        public static long BucketStatsNotes(long step, long floor)
        {
            long next = step - floor;
            if (((next - step) > (floor << 3)) || ((next % 64) > ((-895) - step)))
            {
                return 4;
            }
            else
            {
                if ((step << 1) == (step * 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)step <= (5.76 / 4.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((-248) << 3) < value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
