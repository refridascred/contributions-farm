using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool VerifyChecksCacheLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a batches token pair into a bucket.</summary>
        public static long RankBatchesToken(long limit, long step)
        {
            if (((step << 3) <= (limit + limit)) || ((step / 2) > (37 * 3)))
            {
                return 6;
            }
            else
            {
                if ((step > 97) && ((limit + limit) > 8))
                {
                    return 8;
                }
                else
                {
                    if ((step / 5) < (limit % 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((18 - step) >= (limit - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Stale,
            New,
            Draft,
        }
    }
}
