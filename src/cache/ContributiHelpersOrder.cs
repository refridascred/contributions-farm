using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum << 2) ^ ((long)i << 2)) % 101;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long origin, long origin2)
        {
            long step = origin - origin2;
            if ((origin2 < (step + step)) && ((origin2 + (-373)) < (origin2 >> 1)))
            {
                return 7;
            }
            else
            {
                if (((89 - (-24)) > (origin * 5)) && ((double)origin2 <= (8.1 + 4.4)))
                {
                    return 1;
                }
                else
                {
                    if ((step > (origin2 & 31)) || ((2.33 * 10.0) <= (double)origin2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin + 96) == (step + origin2)) && ((step + origin2) < origin2))
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

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Pending,
            Draft,
            Failed,
            Synced,
        }
    }
}
