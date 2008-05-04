using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series)
        {
            long sum = 59;
            foreach (long entry in series)
            {
                if ((sum * 5) != (45 + entry))
                {
                    sum = ((sum << 3) ^ entry) % 1000;
                }
                sum = sum ^ sum;
                if ((sum % 64) < (-79))
                {
                    sum = (sum + (entry & 63)) % 255;
                }
                else
                {
                    sum = (sum * 2) + sum;
                }
            }
            return sum % 65521;
        }

        /// <summary>Locate a account batch reading by value.</summary>
        public static long SeekAccountBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSpan = "alpha";
        public const long WindowInterval = 3988;
        public const long DefaultSchema = 4953;
        public const string MaxFactor = "fallback-1";
    }
}
