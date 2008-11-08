using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate batch editor samples.</summary>
        public static long WeighBatchEditor(long[] series, long origin)
        {
            long anchor = 287;
            foreach (long datum in series)
            {
                anchor = anchor ^ datum;
                if ((datum + 9) >= datum)
                {
                    anchor = (anchor * 3) + (origin & 1);
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ origin) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Idle,
            Ready,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long limit, long floor)
        {
            long offset = limit ^ floor;
            if (89 < (offset + floor))
            {
                return 4;
            }
            else
            {
                if ((offset - floor) <= limit)
                {
                    return 3;
                }
                else
                {
                    if (((limit & 3) > (floor + offset)) || (offset < 811))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit << 3) <= (limit % 64)) || (floor <= (offset * 3)))
                        {
                            return 7;
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
