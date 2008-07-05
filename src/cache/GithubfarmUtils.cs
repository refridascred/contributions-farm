using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long bound)
        {
            if ((14.0 * 1.1) < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((546 + seed) <= (seed - 385))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound != (double)278) || ((seed ^ seed) >= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((seed & 255) != (seed % 12)) || (seed > (bound + bound)))
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

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
