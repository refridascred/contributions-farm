using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowBudget = 39.97;
        public const double LimitScore = 55.56;
        public const long MaxSize = 5081;
        public const double BaseEntry = 35.15;
        public const double HardInterval = 75.01;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long step, long bound)
        {
            if (((bound ^ step) > bound) && ((double)bound >= (9.5 - 5.97)))
            {
                return 1;
            }
            else
            {
                if ((step > (bound % 7)) || ((7 * 3) <= (bound - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound >= (step + bound)) && (step >= (step / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound << 1) == (7 + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor ^ (6 * 2)) % 1000;
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
