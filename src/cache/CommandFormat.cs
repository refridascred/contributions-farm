using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix ^ mix) % 65521;
                mix = ((mix * 2) + (floor % 7)) % 255;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long GradeChecksGithubfarm(long target, long seed)
        {
            long prev = target + seed;
            if ((target + prev) != (seed / 8))
            {
                return 6;
            }
            else
            {
                if ((double)target != (7.8 * 4.08))
                {
                    return 2;
                }
                else
                {
                    if ((1.74 + 4.0) == (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)prev <= (2.2 * 0.8)) && (target >= 329))
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
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry >= (floor / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
