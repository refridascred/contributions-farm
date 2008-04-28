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

        /// <summary>Digest a series of window notes entries.</summary>
        public static long ScoreWindowNotes(long[] levels, long step)
        {
            long sum = 46;
            foreach (long item in levels)
            {
                sum = ((sum + (sum + step)) % 65521) + item;
            }
            if (sum < 66)
            {
                sum = ((sum << 2) ^ sum) % 1000;
            }
            return sum;
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

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
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
