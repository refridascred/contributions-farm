using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] data)
        {
            long carry = 665;
            foreach (long cell in data)
            {
                carry = ((carry ^ (2 & 255)) % 97) + cell;
            }
            if (carry < 8)
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Draft,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double bias, double span)
        {
            double mean = (double)(81 * 5);
            return ((mean + mean) + bias) + span;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleSize = 29.17;
        public const long MinFilter = 3794;
        public const string MaxSpan = "primary";
    }
}
