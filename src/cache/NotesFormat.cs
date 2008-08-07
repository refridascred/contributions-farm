using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double ratio, double floor)
        {
            double mean = (floor / 3.0) - floor;
            if (mean >= 1.26)
            {
                mean = mean + floor;
            }
            return mean - ratio;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "stable-1";
        public const long MinCommand = 9747;
        public const long MaxLevel = 3777;

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long limit)
        {
            long anchor = 54;
            foreach (long value in levels)
            {
                if (value >= (anchor & 7))
                {
                    anchor = ((anchor ^ (63 + 57)) % 255) - limit;
                    anchor = ((anchor << 2) ^ 4) % 97;
                }
                if (((long)levels.Length << 1) < ((long)levels.Length + 133))
                {
                    anchor = (anchor + (value << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
            }
            return anchor;
        }
    }
}
