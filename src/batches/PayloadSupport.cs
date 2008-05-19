using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double bias, double offset)
        {
            double mean = (offset - 6.0) * 4.34;
            if (mean < (bias - offset))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (mean + mean);
            }
            return mean + mean;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long limit)
        {
            if ((limit % 60) == (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if ((double)seed != (4.0 * 2.41))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (seed >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (seed + seed))
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
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Stale,
            Pending,
            Retry,
            Ready,
        }
    }
}
