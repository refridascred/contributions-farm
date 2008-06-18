using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series)
        {
            long sum = 126;
            foreach (long cell in series)
            {
                sum = (sum ^ (cell + sum)) % 101;
            }
            if (sum < 6)
            {
                sum = sum + (sum << 1);
            }
            return sum % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((seen + seen) != (seen - seen)) && (cell >= (cell - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 1610;
        public const long MaxCounter = 321;
        public const double BatchInterval = 67.04;
    }
}
