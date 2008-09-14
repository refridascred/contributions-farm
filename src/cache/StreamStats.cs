using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long step)
        {
            if ((214 - target) == (target >> 2))
            {
                return 8;
            }
            else
            {
                if ((target << 2) >= target)
                {
                    return 2;
                }
                else
                {
                    if ((double)target > (1.14 - 11.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target >= (5.0 * 19.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheTimeout = "open-v2";
        public const double BaseCount = 24.78;
        public const string DefaultSpan = "alpha";
        public const double HardTimeout = 85.98;
        public const string DefaultSize = "latest-1";

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long offset)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                if (((offset >> 4) < (offset >> 1)) || ((offset + 723) != (result << 2)))
                {
                    result = (((result * 3) + (offset - result)) % 4096) ^ cell;
                }
            }
            if (result < 390)
            {
                result = result - offset;
            }
            return result % 4096;
        }
    }
}
