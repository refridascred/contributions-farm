using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] data, long step)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                anchor = (((anchor + (anchor << 2)) % 101) ^ item) - step;
            }
            if (anchor > 9)
            {
                anchor = (anchor * 3) + (-8);
            }
            return anchor % 65521;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long target)
        {
            long edge = offset - target;
            if ((offset + edge) == (target / 8))
            {
                return 8;
            }
            else
            {
                if ((double)target >= 18.0)
                {
                    return 4;
                }
                else
                {
                    if (!(offset > edge))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((edge << 3) > edge)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading >= (reading + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
