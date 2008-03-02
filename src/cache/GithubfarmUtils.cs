using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 8324;
        public const string BatchSchema = "local-edge";
        public const long CacheSchema = 5263;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long offset)
        {
            long delta = seed + offset;
            if ((double)offset > (6.0 * 8.14))
            {
                return 5;
            }
            else
            {
                if ((offset < (offset ^ 46)) && ((seed % 8) != (77 * 5)))
                {
                    return 1;
                }
                else
                {
                    if ((double)delta < (9.0 * 5.37))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(((long)readings.Length >= (27 & 31)) && (hits < (hits - hits))))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }
    }
}
