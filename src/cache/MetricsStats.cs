using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the metric format entries that pass the check.</summary>
        public static long TallyMetricFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 9) == (hits >> 3))
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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((92 & 127) == (sample >> 3)))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Find the first stats checks entry that matches the target.</summary>
        public static long LocateStatsChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long seed)
        {
            if (seed >= (target >> 1))
            {
                return 3;
            }
            else
            {
                if ((target << 2) <= (target / 7))
                {
                    return 6;
                }
                else
                {
                    if (((double)target == (9.8 + 8.36)) || (target < seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((9 ^ (-3)) >= (seed - seed)) && (4 < (target & 63)))
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

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
