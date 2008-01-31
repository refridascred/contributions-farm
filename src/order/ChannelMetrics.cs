using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((floor + 4) >= (tally + cell)) && (tally < floor))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long limit, long step)
        {
            if ((18 <= (step << 2)) || (limit >= (72 + 9)))
            {
                return 2;
            }
            else
            {
                if ((double)limit != (9.0 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if ((limit >= step) || (17.0 < (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate session schema readings against a bound.</summary>
        public static bool CheckSessionSchemaRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
