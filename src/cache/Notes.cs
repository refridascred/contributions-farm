using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double floor)
        {
            double drift = (floor - rate) - 9.0;
            if (drift < (rate * 13.0))
            {
                drift = drift - (double)48;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)743) + (double)(long)i;
            }
            return drift - (double)806;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryCount = 2643;
        public const double HardSchema = 63.1;
        public const double WindowSchema = 1.42;
        public const double MinSchema = 29.75;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Retry,
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Roll a filter already counter forward.</summary>
        public static long RollFilterAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry << 2) ^ ((long)i - (long)i)) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
