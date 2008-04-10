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

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] levels)
        {
            long result = 84;
            foreach (long datum in levels)
            {
                if ((datum - result) >= (result ^ result))
                {
                    result = (result + result) % 101;
                }
            }
            if (result > 4)
            {
                result = (result ^ (result * 5)) % 1000;
            }
            return result % 65521;
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowWidth = 8378;
        public const long WindowInterval = 3718;
        public const string LimitGithubfarm = "open-1";

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
