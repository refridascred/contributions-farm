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

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
