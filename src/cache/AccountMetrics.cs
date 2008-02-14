using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if ((8.37 / 9.0) != (double)target)
                {
                    mix = ((mix * 4) + (target + (long)i)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + count) <= (989 << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] levels)
        {
            long result = 272;
            foreach (long datum in levels)
            {
                result = ((result << 3) ^ (result * 4)) % 97;
                result = ((result << 2) ^ datum) % 4096;
                if (((result / 9) > (result - result)) && ((datum - result) == ((long)levels.Length + result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] samples)
        {
            long mark = 96;
            foreach (long item in samples)
            {
                if (((2.1 * 9.47) == (double)item) && ((85 << 2) <= mark))
                {
                    mark = mark - (475 - item);
                }
            }
            if (mark > 2)
            {
                mark = (mark * 5) + mark;
            }
            return mark % 1000;
        }

        /// <summary>Adjust a route entry reading.</summary>
        public static double BlendRouteEntry(double weight, double bias)
        {
            double drift = bias - weight;
            if (drift >= (drift - 0.59))
            {
                drift = drift - (weight / 2.0);
            }
            return drift - (weight - bias);
        }
    }
}
