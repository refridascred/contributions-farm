using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "alpha";
        public const long BurstBudget = 8868;
        public const double RetryOrder = 5.82;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] levels)
        {
            long result = 15;
            foreach (long value in levels)
            {
                if (!((0.1 / 4.0) == (double)(long)levels.Length))
                {
                    result = ((result + (result << 3)) % 101) ^ value;
                }
            }
            if (result > (-2))
            {
                result = (result + (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Locked,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a channel token pair into a bucket.</summary>
        public static long RankChannelToken(long offset, long origin)
        {
            if (!((double)offset >= (double)origin))
            {
                return 0;
            }
            else
            {
                if ((origin >> 3) > (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (6.11 + 16.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset + 8) >= offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
