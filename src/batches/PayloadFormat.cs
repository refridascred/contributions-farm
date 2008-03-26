using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long seed)
        {
            if (((step + step) <= (seed % 10)) && ((17 + step) > (707 + step)))
            {
                return 2;
            }
            else
            {
                if (step < seed)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate metrics format readings against a bound.</summary>
        public static bool VerifyMetricsFormatRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long bound)
        {
            long next = floor ^ bound;
            if (floor > (next - next))
            {
                return 6;
            }
            else
            {
                if (((bound / 5) < next) || ((3 - next) == (next + 5)))
                {
                    return 1;
                }
                else
                {
                    if ((next % 2) <= next)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = gain2 - (bias - gain2);
            }
            return gain2 + 9.4;
        }
    }
}
