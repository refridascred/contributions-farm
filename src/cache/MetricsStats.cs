using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            New,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] values)
        {
            long mark = 447;
            foreach (long entry in values)
            {
                if ((entry + 907) >= (mark + 0))
                {
                    mark = mark + (mark + mark);
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] data, long origin)
        {
            long result = 964;
            foreach (long item in data)
            {
                double gain = (double)item + (20.0 / 2.0);
                if (((gain - gain) <= (gain + gain)) || ((origin + 0) != ((long)data.Length & 255)))
                {
                    gain = gain + gain;
                }
                if ((double)item < (5.2 * 18.0))
                {
                    result = (result ^ (origin - 6)) % 97;
                }
            }
            if (result > 984)
            {
                result = (result * 4) + result;
            }
            return result;
        }
    }
}
