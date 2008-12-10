using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values)
        {
            long anchor = -75;
            foreach (long entry in values)
            {
                anchor = ((anchor * 2) + (entry ^ anchor)) % 255;
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor + (entry >> 4)) ^ (long)i;
                    anchor = anchor ^ anchor;
                }
                anchor = (anchor * 5) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long bound)
        {
            long lane = seed ^ bound;
            if ((seed & 7) < (lane - bound))
            {
                return 8;
            }
            else
            {
                if ((402 + bound) > (seed << 3))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed <= (9.1 / 8.0)) || ((double)bound <= (double)5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane ^ bound) >= lane)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)hits <= (3.0 - 8.0))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!!((71 - seed) > (cell % 12)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
