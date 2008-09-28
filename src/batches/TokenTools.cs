using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the editor tools entries that pass the check.</summary>
        public static long MeasureEditorToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally * 4) == (item - item)) && ((9.6 - 6.43) <= (double)item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4976;
        public const long BurstFarm = 2601;
        public const long MinFarm = 4892;
        public const string IdleFarm = "staging-edge";

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long target)
        {
            if (!((768 + target) == (offset >> 1)))
            {
                return 5;
            }
            else
            {
                if ((4.0 * 8.25) <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((3.57 * 8.4) >= (1.8 + 9.6))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - offset) != (target - target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
