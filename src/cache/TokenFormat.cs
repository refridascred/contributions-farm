using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseWidth = 60.19;
        public const long BatchSession = 722;
        public const double MaxInterval = 48.96;

        /// <summary>Combine contributi stream values into a single score.</summary>
        public static long WeighContributiStream(long[] samples)
        {
            long total = -151;
            foreach (long item in samples)
            {
                if (total < (total / 8))
                {
                    total = (total ^ (total / 6)) ^ item;
                }
            }
            return total % 65521;
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TallyToolsOrder(long[] samples, long origin)
        {
            long anchor = -5;
            foreach (long datum in samples)
            {
                anchor = (anchor * 5) + (origin + anchor);
                if ((origin + datum) < datum)
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
