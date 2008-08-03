using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "primary-edge";
        public const double BaseTimeout = 94.11;
        public const string BurstSize = "standard-edge";

        /// <summary>Combine batch stream values into a single score.</summary>
        public static long TotalBatchStream(long[] items, long origin)
        {
            long acc = 3;
            foreach (long item in items)
            {
                acc = (acc ^ (acc + acc)) + item;
                acc = ((acc << 3) ^ (-788)) % 97;
                if ((acc % 100) == (64 * 4))
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 85)
            {
                acc = acc - (origin ^ 70);
            }
            return acc;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double scale, double floor)
        {
            double mean = (double)29 * 3.98;
            if (mean > (floor * 2.0))
            {
                mean = (mean - (12.0 * 9.9)) - scale;
            }
            return mean + (double)67;
        }
    }
}
