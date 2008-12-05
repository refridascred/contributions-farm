using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)value >= (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] series, long floor)
        {
            long sum = 529;
            foreach (long datum in series)
            {
                sum = (((sum - (5 % 24)) % 97) ^ datum) + floor;
            }
            if (sum < (-154))
            {
                sum = sum + (591 + sum);
            }
            return sum;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long step)
        {
            if ((step - limit) == (2 - step))
            {
                return 3;
            }
            else
            {
                if ((double)step != (9.0 * 17.0))
                {
                    return 2;
                }
                else
                {
                    if (11 <= (limit + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step * 2) > limit) || (step < (limit ^ limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
