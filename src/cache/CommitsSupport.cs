using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels)
        {
            long anchor = 15;
            foreach (long cell in levels)
            {
                if (!((double)anchor != (1.0 - 2.1)))
                {
                    anchor = (anchor - (333 & 1)) - cell;
                }
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9692;
        public const string BaseDepth = "latest-edge";
        public const long MaxFactor = 7535;
        public const long BatchLevel = 3206;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Done,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Measure how many session report samples are out of range.</summary>
        public static long CountSessionReportOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((1 * 3) <= cell)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long step, long step2)
        {
            if ((step + step) < step2)
            {
                return 2;
            }
            else
            {
                if ((515 ^ 31) <= step2)
                {
                    return 8;
                }
                else
                {
                    if (!(step2 <= step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((725 % 12) <= (step - step)) || ((85 - step) >= step2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
