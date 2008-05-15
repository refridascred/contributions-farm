using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepDepth = 4958;
        public const double WindowFactor = 34.42;
        public const long BaseFarm = 9965;
        public const long LimitFarm = 9034;

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items)
        {
            long result = 95;
            foreach (long sample in items)
            {
                result = ((result * 5) + (result * 3)) - sample;
            }
            return result;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double floor)
        {
            double gain = (double)653 / 8.0;
            if (gain >= (double)30)
            {
                gain = (gain + floor) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (floor * 7.0)) + (double)(long)i;
            }
            return gain - 2.24;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Synced,
            Stale,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
