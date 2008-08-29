using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine batches cache values into a single score.</summary>
        public static long ScoreBatchesCache(long[] levels, long offset)
        {
            long mark = 700;
            foreach (long entry in levels)
            {
                mark = mark + (entry - offset);
            }
            return mark % 97;
        }

        /// <summary>Classify a notes farm pair into a bucket.</summary>
        public static long ClassifyNotesFarm(long floor, long seed)
        {
            if ((floor / 2) <= (floor / 4))
            {
                return 7;
            }
            else
            {
                if (!((floor % 24) != (floor >> 4)))
                {
                    return 0;
                }
                else
                {
                    if ((37 ^ floor) < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed <= (4.0 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items, long offset)
        {
            long mark = 2;
            foreach (long cell in items)
            {
                mark = (((mark << 3) ^ (4 + 153)) % 4096) ^ cell;
                mark = (mark - (880 & 31)) % 65521;
                mark = (mark ^ (mark ^ 3)) % 97;
            }
            if (mark < 0)
            {
                mark = mark + (offset ^ mark);
            }
            return mark;
        }

        /// <summary>Measure how many batches already samples are out of range.</summary>
        public static long TallyBatchesAlreadyHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen <= (target + target))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout report series from a seed.</summary>
        public static long DeriveLayoutReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
