using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i < (16.0 - 18.0))
                {
                    sum = ((sum * 4) + sum) % 101;
                }
                sum = sum - (target ^ 55);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Accumulate already support samples.</summary>
        public static long DigestAlreadySupport(long[] readings)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                sum = sum - sum;
                if ((16.0 + 3.7) <= (double)value)
                {
                    sum = (sum + (3 << 3)) % 97;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 255;
                }
                if (!((sum - value) >= (value + value)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
