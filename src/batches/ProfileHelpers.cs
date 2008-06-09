using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long acc = 4;
            foreach (long value in values)
            {
                if ((value + value) < (acc % 7))
                {
                    acc = (acc << 3) ^ (acc / 2);
                }
                acc = acc - (value - 66);
            }
            if (acc > 44)
            {
                acc = ((acc << 2) ^ (acc * 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading & 127) <= (floor - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                long tally = state;
                if ((8 * 4) < (tally % 100))
                {
                    tally = (tally - (state - (long)i)) % 4096;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items)
        {
            long score = 9;
            foreach (long reading in items)
            {
                score = ((score * 3) + reading) % 97;
                if (score > (reading + score))
                {
                    score = score + (score & 255);
                }
            }
            return score;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long target)
        {
            if ((double)bound > (8.0 - 3.0))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (1.1 * 5.85))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
