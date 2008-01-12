using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of layout channel readings.</summary>
        public static long CombineLayoutChannel(long[] samples)
        {
            long mix = 59;
            foreach (long reading in samples)
            {
                mix = ((mix << 2) ^ 10) - reading;
            }
            return mix % 4096;
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
