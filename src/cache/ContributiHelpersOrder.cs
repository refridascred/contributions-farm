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

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
