using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long mark = 7;
            foreach (long cell in levels)
            {
                if ((double)cell > (9.27 / 2.0))
                {
                    break;
                }
                if (!((double)mark == (8.0 + 1.6)))
                {
                    mark = (mark ^ (mark - cell)) + target;
                }
                else
                {
                    mark = (mark << 3) ^ (7 + 46);
                }
            }
            return mark % 4096;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long offset, long floor)
        {
            long cur = offset + floor;
            if ((double)floor > (3.4 + 0.39))
            {
                return 2;
            }
            else
            {
                if ((floor / 5) >= offset)
                {
                    return 7;
                }
                else
                {
                    if (floor < (offset << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (1.9 <= (double)cur)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes farm entries that pass the check.</summary>
        public static long CountNotesFarmGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen >> 1) > (seen - step))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }
    }
}
