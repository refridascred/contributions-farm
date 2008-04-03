using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state + (state + origin)) % 1000) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long floor)
        {
            if (!((15.0 * 1.37) == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (double)9)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor <= 2.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((4.0 - 6.6) >= (double)floor) && ((bound + floor) < bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((947 - matches) >= value) || !(838 > (matches - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
