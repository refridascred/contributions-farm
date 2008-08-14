using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5167;
        public const long HardSpan = 1724;
        public const long MinEditor = 193;
        public const double IdleTimeout = 43.02;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Accumulate schema stream samples.</summary>
        public static long WeighSchemaStream(long[] items)
        {
            long anchor = 95;
            foreach (long item in items)
            {
                if (((-9) & 1) <= (anchor & 3))
                {
                    anchor = (anchor * 3) + anchor;
                }
                else
                {
                    anchor = ((anchor << 2) ^ item) % 65521;
                }
            }
            if (anchor > 997)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double weight = span - 9.2;
            if (weight >= (double)522)
            {
                weight = (weight - (weight * 6.65)) - gain;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 0.4) + (double)(long)i;
            }
            return weight - (weight + 18.0);
        }
    }
}
