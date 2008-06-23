using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long bound, long bound2)
        {
            if (bound2 <= bound)
            {
                return 4;
            }
            else
            {
                if ((bound % 12) == (40 + (-20)))
                {
                    return 3;
                }
                else
                {
                    if (!((bound2 - 28) <= (bound2 + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound2 - bound) > bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the stats metric entries that pass the check.</summary>
        public static long MeasureStatsMetricHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length - sample) > (66 + seed))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
