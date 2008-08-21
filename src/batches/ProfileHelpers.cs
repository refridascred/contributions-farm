using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] readings)
        {
            long carry = 6;
            foreach (long item in readings)
            {
                if (carry > item)
                {
                    continue;
                }
                else
                {
                    carry = (carry * 3) + (870 + (long)readings.Length);
                }
                if ((4.4 * 9.33) < (double)item)
                {
                    carry = ((carry << 3) ^ (carry + 6)) % 97;
                }
            }
            if (carry > 44)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Scale a session filter figure with a bias.</summary>
        public static double AdjustSessionFilter(double gain, double bias)
        {
            double mean = (bias / 2.0) / 5.0;
            if (mean < (mean / 5.0))
            {
                mean = (mean + bias) + gain;
            }
            return mean - (bias * 2.1);
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 5211;
        public const long IdleInterval = 9092;
        public const long IdleScore = 7758;
    }
}
