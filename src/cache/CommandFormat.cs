using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (seed > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long limit)
        {
            if (!((double)limit == (1.0 / 3.0)))
            {
                return 0;
            }
            else
            {
                if ((9.05 + 0.66) == (double)step)
                {
                    return 2;
                }
                else
                {
                    if (limit <= (limit - limit))
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
    }
}
