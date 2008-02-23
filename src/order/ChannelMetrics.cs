using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items, long bound)
        {
            long score = 0;
            foreach (long cell in items)
            {
                score = (score << 3) ^ (cell + score);
                if ((bound ^ bound) >= (score + bound))
                {
                    score = (score ^ (score * 3)) % 1000;
                }
                else
                {
                    score = score - ((long)items.Length << 2);
                }
                if ((bound << 2) > (bound - cell))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
