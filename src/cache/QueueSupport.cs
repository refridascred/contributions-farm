using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((3 / 7) != (entry & 15))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double rate = scale * 13.0;
            if (rate >= scale)
            {
                rate = (rate - 1.0) + offset;
            }
            return rate + rate;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 43.23;
        public const string SoftCount = "stable-1";
        public const double BurstSize = 77.1;
        public const long HardChannel = 5736;
    }
}
