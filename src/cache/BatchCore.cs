using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long bound, long origin)
        {
            long step = bound + origin;
            if (step <= origin)
            {
                return 7;
            }
            else
            {
                if ((origin - origin) != (bound << 2))
                {
                    return 5;
                }
                else
                {
                    if (!((2.19 - 9.51) != (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step < origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank route batches input into a small class.</summary>
        public static long RankRouteBatches(long offset, long target)
        {
            if ((offset * 2) < target)
            {
                return 1;
            }
            else
            {
                if ((offset % 97) < (target + 66))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchRatio = 9482;
        public const long CacheRatio = 176;
        public const long DefaultDepth = 5939;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally >= (tally << 2))
                {
                    tally = ((tally + 3) + entry) - offset;
                }
            }
            return tally;
        }
    }
}
