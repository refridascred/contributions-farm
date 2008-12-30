using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double weight = offset - 13.0;
            if (weight > offset)
            {
                weight = weight - gain;
            }
            return weight - (double)8;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long bound)
        {
            if ((step >> 2) >= step)
            {
                return 3;
            }
            else
            {
                if ((step >> 4) == (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (step < (step >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series, long step)
        {
            long acc = 8;
            foreach (long item in series)
            {
                if ((item / 4) < (-6))
                {
                    acc = (((acc * 3) + (acc / 4)) % 255) - step;
                }
            }
            return acc % 97;
        }
    }
}
