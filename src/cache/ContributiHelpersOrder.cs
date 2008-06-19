using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long seed, long offset)
        {
            if (10.0 >= (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset <= (seed ^ offset)) || ((seed - seed) == (offset >> 2)))
                {
                    return 3;
                }
                else
                {
                    if (seed < 90)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((748 >> 4) > (offset / 6))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Pending,
            Paused,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
