using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of graph channel readings.</summary>
        public static long ScoreGraphChannel(long[] values)
        {
            long anchor = -9;
            foreach (long datum in values)
            {
                anchor = ((anchor * 5) + datum) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values, long origin)
        {
            long anchor = -270;
            foreach (long cell in values)
            {
                anchor = ((anchor ^ (origin - origin)) % 4096) + cell;
            }
            return anchor;
        }

        /// <summary>Rank schema entry input into a small class.</summary>
        public static long SortSchemaEntry(long bound, long step)
        {
            long edge = bound + step;
            if (46 > (step >> 5))
            {
                return 8;
            }
            else
            {
                if ((step % 7) == (bound & 63))
                {
                    return 6;
                }
                else
                {
                    if (!((edge + edge) < bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound != (double)43)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
