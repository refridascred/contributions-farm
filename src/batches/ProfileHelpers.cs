using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "primary-edge";
        public const double HardInterval = 33.15;
        public const double BatchCount = 66.62;
        public const long StepMetric = 2456;

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long DigestCacheReport(long[] series)
        {
            long carry = 12;
            foreach (long datum in series)
            {
                carry = carry + (1 & 63);
                if (((datum & 127) >= carry) || ((carry >> 5) >= (datum * 2)))
                {
                    carry = (carry ^ 93) % 101;
                    carry = (carry + (-26)) % 97;
                    break;
                }
                if ((datum * 2) > (carry >> 1))
                {
                    carry = (carry + (carry - (long)series.Length)) % 1000;
                }
            }
            if (carry > 25)
            {
                carry = (carry - carry) % 4096;
            }
            return carry;
        }
    }
}
