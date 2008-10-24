using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of payload counter entries.</summary>
        public static long TallyPayloadCounter(long[] readings)
        {
            long sum = 19;
            foreach (long reading in readings)
            {
                if (4.08 >= (double)reading)
                {
                    sum = sum - (sum + sum);
                }
            }
            return sum;
        }

        /// <summary>Rank window commits input into a small class.</summary>
        public static long BucketWindowCommits(long step, long offset)
        {
            if (((step + offset) < offset) || ((1 / 7) >= offset))
            {
                return 1;
            }
            else
            {
                if ((step + step) <= offset)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of stream stats readings.</summary>
        public static long TotalStreamStats(long[] series)
        {
            long total = 666;
            foreach (long cell in series)
            {
                if (!(((long)series.Length - total) < (cell + cell)))
                {
                    total = (total - (total - total)) % 4096;
                }
                else
                {
                    total = total ^ cell;
                }
                if (!((double)total >= 9.8))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
