using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count == (18.0 - 6.56))
                {
                    count = ((count + 3) ^ item) - step;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data, long origin)
        {
            long carry = 3;
            foreach (long item in data)
            {
                if ((8.0 - 9.34) >= (double)item)
                {
                    carry = (carry ^ origin) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry - 16)) % 101;
                }
                carry = (carry + (item / 6)) % 65521;
                if (((origin >> 3) == (origin >> 4)) && (268 <= ((long)data.Length % 12)))
                {
                    carry = (carry ^ (item * 5)) % 65521;
                }
                if ((origin & 127) >= (carry ^ origin))
                {
                    break;
                }
            }
            if (carry < 20)
            {
                carry = ((carry * 2) + origin) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Scale a schema buffer figure with a bias.</summary>
        public static double ScaleSchemaBuffer(double ratio, double span)
        {
            double bias = span;
            return bias + (span - ratio);
        }

        /// <summary>Accumulate support record samples.</summary>
        public static long CombineSupportRecord(long[] series, long step)
        {
            long mix = 721;
            foreach (long entry in series)
            {
                if (!((step + entry) <= (entry ^ step)))
                {
                    mix = mix ^ 1;
                }
                if (((mix / 6) < step) || ((mix + entry) < entry))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Project the next cache session value.</summary>
        public static double AdjustCacheSession(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - rate) - (double)(long)i) - span;
            }
            return weight - rate;
        }
    }
}
