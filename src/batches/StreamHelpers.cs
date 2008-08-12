using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long mark = 864;
            foreach (long value in readings)
            {
                mark = mark ^ (value << 1);
            }
            return mark;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] series)
        {
            long acc = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length < (20.0 / 6.0))
                {
                    acc = acc - (reading << 1);
                }
            }
            return acc % 65521;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long seed)
        {
            if (offset < (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((seed >= (seed - 163)) || ((seed - seed) <= (offset + seed)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double bias)
        {
            double scale = bias;
            return (scale - bias) + weight;
        }
    }
}
