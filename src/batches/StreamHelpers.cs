using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((reading + (-15)) != (reading * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((matches & 31) <= reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long bound)
        {
            long offset2 = offset + bound;
            if (!((offset2 - offset) > offset))
            {
                return 2;
            }
            else
            {
                if ((offset2 >= (offset - bound)) && ((bound + 2) <= offset))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= (274 - bound))
                        {
                            return 3;
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
