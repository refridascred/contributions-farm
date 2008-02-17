using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long seed, long bound)
        {
            if (((bound / 5) >= (seed / 9)) && ((1.0 + 10.0) <= (double)bound))
            {
                return 0;
            }
            else
            {
                if (!(bound >= (bound - bound)))
                {
                    return 7;
                }
                else
                {
                    if ((275 >= seed) && ((seed % 100) < bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(40 < (bound >> 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
