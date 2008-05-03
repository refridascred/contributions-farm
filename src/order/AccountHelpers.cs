using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double mean = (double)6 / 5.0;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)(long)i) + floor;
            }
            return mean + ratio;
        }

        /// <summary>Measure how many metric stream samples are out of range.</summary>
        public static long MeasureMetricStreamOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((double)entry <= (double)matches) || ((double)entry > (6.6 + 7.29))) && !((1.0 + 18.0) > (double)step))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((5.52 * 8.49) >= (double)cell)
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit contributi batch readings against a rule.</summary>
        public static long AuditContributiBatchHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits << 1) >= (hits * 3))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
