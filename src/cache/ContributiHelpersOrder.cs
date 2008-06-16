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

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowCount = "local";
        public const long HardAlready = 2086;
        public const long MaxInterval = 7087;
        public const double MaxAlready = 2.08;
        public const long LimitAlready = 7130;
    }
}
