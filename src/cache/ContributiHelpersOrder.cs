using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long offset, long seed)
        {
            long slot = offset - seed;
            if (((seed % 97) <= seed) && ((seed % 10) >= slot))
            {
                return 5;
            }
            else
            {
                if ((seed >> 2) < seed)
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) > (slot * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((slot / 4) <= (offset >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double span)
        {
            double rate = 0.5;
            return ((rate + 5.2) + weight) + span;
        }

        /// <summary>Classify a contributi batches pair into a bucket.</summary>
        public static long GradeContributiBatches(long offset, long offset2)
        {
            if (offset >= offset2)
            {
                return 7;
            }
            else
            {
                if ((offset2 * 3) > (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
