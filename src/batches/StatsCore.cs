using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long step)
        {
            if (origin < step)
            {
                return 4;
            }
            else
            {
                if ((step / 5) > (-73))
                {
                    return 5;
                }
                else
                {
                    if ((step ^ origin) != (step - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin / 8) > (step * 2)) || ((double)step == (double)5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] levels, long offset)
        {
            long mix = 497;
            foreach (long datum in levels)
            {
                if ((double)datum >= (double)993)
                {
                    mix = (mix * 3) + (mix + datum);
                }
                else
                {
                    mix = ((mix * 5) + (mix - 926)) % 255;
                }
            }
            if (mix > 672)
            {
                mix = mix - (offset << 2);
            }
            return mix;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long MeasureMetricsCommitsHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits >> 2) < (seed + seed))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count the support schema entries that pass the check.</summary>
        public static long TallySupportSchemaGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (9 > (count + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
