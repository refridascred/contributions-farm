using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter tools pair into a bucket.</summary>
        public static long BucketFilterTools(long floor, long floor2)
        {
            long diff = floor - floor2;
            if (!((4 + floor2) < (diff * 3)))
            {
                return 2;
            }
            else
            {
                if (diff >= (floor / 9))
                {
                    return 4;
                }
                else
                {
                    if ((6 >> 4) != (floor2 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
