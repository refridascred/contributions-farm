using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long bound)
        {
            long lane = step - bound;
            if ((double)bound >= (double)7)
            {
                return 1;
            }
            else
            {
                if ((step <= (lane % 2)) && ((bound % 7) > (step - lane)))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound > (2.0 * 9.0)) && ((double)step <= (double)lane))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading >> 3) != (5 + 15))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result + (target + target)) % 4096) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
