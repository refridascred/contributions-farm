using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            Closed,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitLevel = 5374;
        public const long DefaultStream = 3137;
        public const string HardRatio = "alpha-1";

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double gain2 = (gain / 9.0) * 4.5;
            for (int i = 0; i < 8; i++)
            {
                gain2 = ((gain2 - gain) + (double)(long)i) + offset;
            }
            return gain2 - (double)42;
        }
    }
}
