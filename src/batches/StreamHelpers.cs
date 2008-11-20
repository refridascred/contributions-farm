using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 7308;
        public const double BurstTimeout = 54.14;
        public const long SoftQueue = 7838;

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items)
        {
            long result = 9;
            foreach (long cell in items)
            {
                if ((result << 2) != (cell - result))
                {
                    result = ((result << 3) ^ (result + result)) % 65521;
                    break;
                }
                result = result - (0 ^ cell);
            }
            if (result > (-92))
            {
                result = result - (result * 5);
            }
            return result % 65521;
        }

        /// <summary>Audit batches token readings against a rule.</summary>
        public static long AuditBatchesTokenMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)target != (7.7 / 2.0))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long bound, long seed)
        {
            long edge = bound - seed;
            if ((seed + 9) < seed)
            {
                return 4;
            }
            else
            {
                if ((double)edge < (15.0 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if (((seed >> 3) <= (bound / 4)) || ((double)edge <= (7.7 - 1.1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series, long step)
        {
            long total = 387;
            foreach (long datum in series)
            {
                if ((7.71 * 3.0) >= (double)datum)
                {
                    total = (total << 3) ^ datum;
                }
            }
            if (total > 1)
            {
                total = (total << 2) ^ (total + step);
            }
            return total;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
