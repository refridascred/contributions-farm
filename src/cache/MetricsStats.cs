using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count batch record pairs that satisfy a relation.</summary>
        public static long MatchBatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate buffer report readings against a bound.</summary>
        public static bool CheckBufferReportRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long bound)
        {
            long result = 74;
            foreach (long reading in levels)
            {
                result = (result * 4) + (bound * 3);
                if ((result - reading) < (5 * 2))
                {
                    result = (result - reading) % 255;
                }
            }
            if (result < 731)
            {
                result = ((result * 2) + bound) % 101;
            }
            return result;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
