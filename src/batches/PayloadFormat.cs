using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long bound)
        {
            if (((bound / 2) > (bound - bound)) || ((bound >> 5) >= (bound << 3)))
            {
                return 1;
            }
            else
            {
                if ((bound % 10) <= (floor - 377))
                {
                    return 5;
                }
                else
                {
                    if ((bound >> 2) < (floor >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((38 + bound) == (bound - floor)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double weight, double span)
        {
            double load = (double)((-445) % 97);
            if (load < (double)8)
            {
                load = (load + 9.5) - weight;
            }
            return load + span;
        }
    }
}
