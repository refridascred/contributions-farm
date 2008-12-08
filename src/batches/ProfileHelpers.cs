using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((((0 + tally) >= cell) && ((tally + cell) > (tally * 2))) || ((cell * 3) != (cell ^ 320)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (15 >= (40 + item))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches token series from a seed.</summary>
        public static long DeriveBatchesToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a editor format value against two limits.</summary>
        public static long ClassifyEditorFormat(long limit, long step)
        {
            long bound = limit + step;
            if (((limit + step) > (limit + bound)) && ((step ^ step) <= 63))
            {
                return 4;
            }
            else
            {
                if (step > (42 ^ bound))
                {
                    return 1;
                }
                else
                {
                    if (((-80) + bound) < step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.03 - 7.6) > (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
