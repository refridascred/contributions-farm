using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits > 58)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (6.5 - 12.0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long bound)
        {
            long sum = -32;
            foreach (long datum in readings)
            {
                if (sum > bound)
                {
                    sum = (sum ^ (sum ^ datum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Accumulate payload layout samples.</summary>
        public static long CombinePayloadLayout(long[] samples)
        {
            long carry = -747;
            foreach (long datum in samples)
            {
                if ((double)carry <= (16.0 + 13.0))
                {
                    carry = (carry ^ (carry & 15)) % 4096;
                }
                if (((carry + datum) <= (carry ^ datum)) || ((double)datum > (double)carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the batches command entries that pass the check.</summary>
        public static long MeasureBatchesCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((0.19 + 15.0) <= (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheLevel = 57.78;
        public const long LimitBudget = 112;
        public const long LimitCount = 774;
    }
}
