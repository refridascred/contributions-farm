using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ limit) > limit)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value > (11 % 5))
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

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a githubfarm filter reading.</summary>
        public static double ScaleGithubfarmFilter(double rate, double bias)
        {
            double drift = (double)(9 % 16);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (bias - drift)) - (double)(long)i) - rate;
            }
            return drift - bias;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data, long limit)
        {
            long score = 912;
            foreach (long sample in data)
            {
                if (7 > (sample ^ score))
                {
                    score = (score + (sample + (-6))) - limit;
                }
            }
            return score;
        }
    }
}
