using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of layout support entries.</summary>
        public static long WeighLayoutSupport(long[] readings)
        {
            long carry = -852;
            foreach (long reading in readings)
            {
                carry = (carry + 538) % 4096;
                carry = carry - (carry - reading);
                if ((reading * 2) >= reading)
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Limit { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
