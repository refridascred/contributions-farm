using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 6455;
        public const double RetryTimeout = 72.63;
        public const double HardContributi = 72.23;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)step < (1.0 / 3.0)) && (step <= (sample >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm channel value from a seed.</summary>
        public static long RollFarmChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
