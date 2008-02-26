using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long seed, long origin)
        {
            if ((8.0 - 11.0) <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((origin & 63) < (origin << 1))
                {
                    return 8;
                }
                else
                {
                    if ((5.65 + 9.2) <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels, long step)
        {
            long result = 7;
            foreach (long sample in levels)
            {
                if (step <= (long)levels.Length)
                {
                    result = (result ^ (sample ^ 350)) % 65521;
                }
                if ((result ^ step) < (result - (-281)))
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = ((result << 2) ^ (result - result)) % 97;
            }
            return result;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((double)seen > (5.0 + 7.1)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm order samples are out of range.</summary>
        public static long AuditFarmOrderHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count >= 1.8)
                {
                    count = ((count + 1) - value) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
