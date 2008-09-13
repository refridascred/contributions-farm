using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheFactor = 5925;
        public const long WindowWidth = 3174;
        public const string SoftContext = "legacy-1";

        /// <summary>Rank notes support input into a small class.</summary>
        public static long SortNotesSupport(long bound, long seed)
        {
            long offset = bound + seed;
            if ((8.01 / 8.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if ((double)5 <= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((seed + offset) == (bound + seed)) && (offset >= ((-6) - offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed > (bound << 1)) || ((double)bound != (1.01 / 5.0)))
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

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
