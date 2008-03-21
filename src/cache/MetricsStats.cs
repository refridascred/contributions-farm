using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 6417;
        public const long StepSize = 8601;
        public const long BurstCommits = 2653;

        /// <summary>Audit record checks readings against a rule.</summary>
        public static long TallyRecordChecksHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((85 + 27) >= tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits >> 5) >= hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix + 40) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long target)
        {
            if (target >= (463 ^ target))
            {
                return 3;
            }
            else
            {
                if (!((double)target > (0.84 - 4.0)))
                {
                    return 0;
                }
                else
                {
                    if (4 >= (target / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
