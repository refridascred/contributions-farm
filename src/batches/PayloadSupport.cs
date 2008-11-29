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

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseWidth = 1864;
        public const long StepGraph = 9341;
        public const long LimitGraph = 589;
        public const string LimitTimeout = "stable";
    }
}
