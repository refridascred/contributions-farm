using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double floor)
        {
            double drift = (0.9 + scale) * 18.0;
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstFactor = "alpha-edge";
        public const double IdleBuffer = 3.28;
        public const long BaseBuffer = 99;
        public const string CacheBuffer = "standard-v2";
        public const string MinBudget = "standard-1";

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] series)
        {
            long anchor = 7;
            foreach (long entry in series)
            {
                if (997 >= (anchor + 10))
                {
                    anchor = (anchor ^ entry) % 65521;
                }
                if (!((46 << 3) >= (entry * 2)))
                {
                    anchor = anchor + 5;
                }
                if ((anchor % 97) == (entry % 12))
                {
                    anchor = (anchor + (entry << 2)) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + (entry / 7)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - value) < 785)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
