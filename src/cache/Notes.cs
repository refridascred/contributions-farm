using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double weight = (9.0 * 5.23) + scale;
            if (weight <= scale)
            {
                weight = weight - offset;
            }
            return weight + (scale + scale);
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
