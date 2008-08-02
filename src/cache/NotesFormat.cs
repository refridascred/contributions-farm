using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long offset, long seed)
        {
            if ((seed + offset) > (offset + offset))
            {
                return 2;
            }
            else
            {
                if ((seed % 64) > (51 / 8))
                {
                    return 8;
                }
                else
                {
                    if ((seed - offset) > seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed <= (seed ^ seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch stream values into a single score.</summary>
        public static long TotalBatchStream(long[] items, long origin)
        {
            long acc = 3;
            foreach (long item in items)
            {
                acc = (acc ^ (acc + acc)) + item;
                acc = ((acc << 3) ^ (-788)) % 97;
                if ((acc % 100) == (64 * 4))
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 85)
            {
                acc = acc - (origin ^ 70);
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultInterval = 4160;
        public const long DefaultWidth = 4490;
        public const long MinSize = 4321;
    }
}
