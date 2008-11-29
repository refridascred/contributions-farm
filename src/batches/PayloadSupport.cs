using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long bound, long floor)
        {
            long diff = bound ^ floor;
            if (((diff * 3) != (bound / 4)) && ((23 + floor) == (bound + bound)))
            {
                return 2;
            }
            else
            {
                if (((double)floor >= (double)bound) || ((diff ^ floor) <= (diff - bound)))
                {
                    return 5;
                }
                else
                {
                    if ((5.0 / 3.0) <= (double)diff)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((acc / 6) < acc)
                {
                    acc = (acc ^ floor) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
