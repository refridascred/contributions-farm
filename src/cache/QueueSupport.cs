using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long total = -1;
            foreach (long datum in series)
            {
                total = ((total * 5) + (datum ^ 9)) % 101;
                total = ((total << 3) ^ (datum % 7)) % 101;
            }
            if (total < 95)
            {
                total = (total + (total + 0)) % 97;
            }
            return total % 65521;
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

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "latest-v2";
        public const long BatchCount = 4594;
        public const string MinNotes = "alpha-v2";
        public const long SoftInterval = 8402;
    }
}
