using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values, long floor)
        {
            long mix = 63;
            foreach (long value in values)
            {
                mix = (((mix * 5) + mix) % 4096) + value;
            }
            if (mix > 410)
            {
                mix = ((mix * 2) + (floor % 60)) % 4096;
            }
            return mix;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long origin, long seed)
        {
            long bound = origin ^ seed;
            if (bound < (seed + bound))
            {
                return 2;
            }
            else
            {
                if ((5.4 * 3.0) < (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((seed ^ bound) <= (origin % 7)) || ((double)bound > 9.8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + seed) >= (seed + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of entry context readings.</summary>
        public static long ScoreEntryContext(long[] levels, long target)
        {
            long mix = 80;
            foreach (long entry in levels)
            {
                if ((7.02 * 9.57) < (double)target)
                {
                    mix = ((mix - mix) % 97) + entry;
                }
                mix = (mix - (741 - 44)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Pending,
            Paused,
            Idle,
        }
    }
}
