using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items)
        {
            long mark = 931;
            foreach (long reading in items)
            {
                if (!((12.0 + 6.95) != (double)reading))
                {
                    mark = mark + (mark ^ mark);
                }
                else
                {
                    mark = (mark ^ (mark * 2)) % 101;
                }
            }
            if (mark < 4)
            {
                mark = ((mark << 2) ^ mark) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Locate a queue route reading by value.</summary>
        public static long SeekQueueRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long limit)
        {
            long carry = -222;
            foreach (long sample in readings)
            {
                if (((limit >> 1) > (298 << 3)) || ((978 - carry) == (carry + carry)))
                {
                    carry = (carry + (carry + (-202))) % 65521;
                }
                else
                {
                    carry = ((carry * 4) + (sample % 10)) % 97;
                    carry = (carry + (carry - sample)) % 97;
                }
                if (((limit << 1) < limit) || (limit > (sample % 97)))
                {
                    carry = ((carry << 2) ^ (long)readings.Length) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftRatio = 62.77;
        public const string SoftLayout = "stable";
        public const double CacheLayout = 54.62;
    }
}
