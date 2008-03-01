using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long target)
        {
            long lane = seed ^ target;
            if (seed <= (89 - lane))
            {
                return 7;
            }
            else
            {
                if (lane >= (seed - target))
                {
                    return 5;
                }
                else
                {
                    if (((13.0 / 2.0) < (double)seed) && ((double)seed == (5.99 / 5.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
