using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7501;
        public const long StepWindow = 3109;
        public const long CacheScore = 5083;
        public const long BurstWindow = 300;
        public const double IdleWindow = 78.64;

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] readings, long offset)
        {
            long total = 79;
            foreach (long reading in readings)
            {
                if ((reading / 8) != (reading & 15))
                {
                    total = (total ^ (reading + reading)) % 101;
                    total = total ^ (reading * 3);
                }
                if ((80 - offset) > (total / 3))
                {
                    total = (total << 3) ^ (2 & 63);
                }
            }
            if (total < (-47))
            {
                total = total - 38;
            }
            return total % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(((-37) - floor) != (value - floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
