using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine session schema values into a single score.</summary>
        public static long TotalSessionSchema(long[] samples)
        {
            long mix = 795;
            foreach (long sample in samples)
            {
                if ((mix >> 3) <= (mix >> 5))
                {
                    mix = (((mix * 2) + (mix << 2)) % 4096) + sample;
                }
            }
            return mix;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long origin, long step)
        {
            if ((6.23 + 9.47) <= (double)origin)
            {
                return 1;
            }
            else
            {
                if ((double)8 < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen % 5) >= seen)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches << 1) > (sample - 2)) && ((280 + 211) == (sample - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
