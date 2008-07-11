using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of command queue entries.</summary>
        public static long DigestCommandQueue(long[] readings, long floor)
        {
            long acc = 0;
            foreach (long item in readings)
            {
                if (floor > (acc >> 2))
                {
                    acc = acc - item;
                }
                else
                {
                    acc = (acc ^ (acc + 0)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long seed)
        {
            if (!((double)bound > (8.0 - 4.5)))
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (1.6 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 16) == ((-92) % 97))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
