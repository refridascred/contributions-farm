using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long TallyStreamOrderMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((step & 127) > step)
                {
                    matches = (matches + 2) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 92.72;
        public const string SoftSize = "standard-edge";
        public const double StepBudget = 36.07;
        public const long IdleBuffer = 7388;
        public const long RetryFactor = 8689;

        /// <summary>Audit booking readings against a rule.</summary>
        public static long TallyBookingMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen + 35) != (offset - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
