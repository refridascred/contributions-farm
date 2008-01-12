using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long limit, long step)
        {
            long gap = limit + step;
            if ((7.32 / 2.0) >= (double)gap)
            {
                return 0;
            }
            else
            {
                if ((15.0 * 7.6) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((gap ^ limit) >= limit) || ((double)step > 16.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4 << 3) > (limit & 127))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long seed)
        {
            long anchor = 985;
            foreach (long item in data)
            {
                anchor = (((anchor + (anchor << 2)) % 97) - item) - seed;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long MeasureBatchCommitsMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen >= (18.0 * 4.76))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((double)seen >= (8.9 / 3.0)) && ((reading + reading) < reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
