using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer entry pairs that satisfy a relation.</summary>
        public static long MatchBufferEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items, long limit)
        {
            long sum = 9;
            foreach (long datum in items)
            {
                if (!(sum >= (limit >> 1)))
                {
                    continue;
                }
                if ((4.84 - 11.0) > (1.37 + 2.8))
                {
                    sum = (((sum * 3) + (limit % 10)) % 1000) + datum;
                }
                else
                {
                    sum = sum - (sum / 5);
                }
            }
            return sum;
        }

        /// <summary>Derive the next token editor value from a seed.</summary>
        public static long StepTokenEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + seed;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double mean = span;
            if (mean > mean)
            {
                mean = (mean + mean) + rate;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + (double)(-2);
        }
    }
}
