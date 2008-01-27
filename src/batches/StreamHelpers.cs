using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((double)floor != (6.0 - 6.0))
            {
                return 4;
            }
            else
            {
                if ((bound + floor) > 4)
                {
                    return 3;
                }
                else
                {
                    if (!((5 - seed) == (bound % 10)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (7 - reading))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (3.1 - 2.81))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
