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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "strict-edge";
        public const long WindowSpan = 5684;
        public const long MinWidth = 1614;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
