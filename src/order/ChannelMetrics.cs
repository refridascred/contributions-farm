using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                if ((9.0 / 2.0) != (double)mark)
                {
                    mark = mark ^ target;
                    mark = (mark - (mark - target)) % 1000;
                    continue;
                }
                if (1 < (long)i)
                {
                    mark = (mark * 2) + ((long)i + target);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
