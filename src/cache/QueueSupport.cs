using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxLevel = 7380;
        public const long BaseAlready = 2185;
        public const long DefaultAlready = 5849;
        public const string WindowAlready = "primary";
        public const double BatchLevel = 35.87;

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double load = offset;
            return (load + load) + ratio;
        }
    }
}
