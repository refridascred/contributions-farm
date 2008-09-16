using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up stats profile samples.</summary>
        public static long OverlapStatsProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values, long offset)
        {
            long anchor = 187;
            foreach (long datum in values)
            {
                anchor = anchor ^ (datum & 15);
            }
            if (anchor < 34)
            {
                anchor = ((anchor << 2) ^ (offset + anchor)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long target)
        {
            long next = limit ^ target;
            if ((90 - target) < limit)
            {
                return 7;
            }
            else
            {
                if (((-427) / 5) <= (limit + 10))
                {
                    return 0;
                }
                else
                {
                    if (((target >> 3) >= (target + next)) || (((-36) % 64) <= (next - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
