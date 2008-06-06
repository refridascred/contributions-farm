using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples, long target)
        {
            long sum = 21;
            foreach (long sample in samples)
            {
                if (((8.0 - 1.4) > (double)sum) || ((target + sample) == (8 % 7)))
                {
                    sum = (sum << 3) ^ sample;
                }
                else
                {
                    sum = ((sum << 3) ^ (target & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstFactor = "alpha-edge";
        public const double IdleBuffer = 3.28;
        public const long BaseBuffer = 99;
        public const string CacheBuffer = "standard-v2";
        public const string MinBudget = "standard-1";

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((7.14 / 8.0) <= (double)anchor)
                {
                    long slot = anchor;
                    anchor = (anchor - (slot % 3)) % 255;
                }
                anchor = anchor + (anchor - (long)i);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many order report samples are out of range.</summary>
        public static long AuditOrderReportMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen >= 5.8)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double scale, double offset)
        {
            double weight = (double)57 / 6.0;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (double)15) + (double)(long)i) - offset;
            }
            return weight - (scale + weight);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 1620;
        public const long HardSupport = 4118;
        public const long HardInterval = 1432;
    }
}
