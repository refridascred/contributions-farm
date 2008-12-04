using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 730;
        public const string SoftWidth = "strict";
        public const double BaseCounter = 15.82;
        public const long HardLevel = 8759;

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 > rate)
            {
                rate2 = (rate2 - (rate2 - rate)) - offset;
            }
            else
            {
                rate2 = rate2 + (rate - 7.0);
            }
            return rate2 + 9.0;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long sum = -58;
            foreach (long value in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (((sum ^ (long)i) % 97) ^ value) - limit;
                }
                sum = (sum + 4) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "cached-edge";
        public const double LimitSize = 43.12;
        public const long DefaultWidth = 646;
    }
}
