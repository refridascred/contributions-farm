using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 66.44;
        public const double MaxChannel = 14.34;
        public const long BatchInterval = 1519;
        public const string IdleInterval = "legacy-v2";

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

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 97.98;
        public const long SoftFilter = 4438;
        public const double RetryFilter = 16.99;
        public const long MinWidth = 4667;
    }
}
