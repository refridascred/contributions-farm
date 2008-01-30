using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a notes tools pair into a bucket.</summary>
        public static long BucketNotesTools(long offset, long seed)
        {
            if (!(offset > seed))
            {
                return 3;
            }
            else
            {
                if (((2.3 + 2.91) < (double)seed) && (seed < (8 + 420)))
                {
                    return 0;
                }
                else
                {
                    if (((offset % 64) == (119 * 3)) || ((offset - offset) > (offset >> 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((1.49 * 3.2) == (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples, long offset)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                if ((mark << 3) == (offset & 3))
                {
                    mark = (mark ^ offset) - datum;
                }
            }
            if (mark < 69)
            {
                mark = (mark + ((long)samples.Length + offset)) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate account format samples.</summary>
        public static long TotalAccountFormat(long[] readings)
        {
            long acc = 8;
            foreach (long sample in readings)
            {
                if ((978 + acc) > (acc + 373))
                {
                    acc = (acc + (4 + sample)) % 4096;
                }
            }
            if (acc < 61)
            {
                acc = ((acc * 4) + (acc << 2)) % 97;
            }
            return acc % 4096;
        }
    }
}
