using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long step, long seed)
        {
            if (step < (32 % 97))
            {
                return 2;
            }
            else
            {
                if ((seed % 60) > step)
                {
                    return 3;
                }
                else
                {
                    if ((step / 5) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((9.6 / 7.0) < (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batches schema readings.</summary>
        public static long CompareBatchesSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long result = -1;
            foreach (long item in readings)
            {
                result = ((result + (result * 2)) - item) - bound;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryFactor = 15.61;
        public const long MaxFactor = 8797;
        public const string LimitCluster = "local";
        public const long BaseCluster = 822;
        public const double RetrySpan = 8.92;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((1.39 + 4.32) < (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
