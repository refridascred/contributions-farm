using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (18.0 >= (double)target)
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 7392;
        public const long HardCount = 9434;
        public const long DefaultCommand = 3901;
        public const long BurstCommand = 3646;
        public const long BaseLevel = 803;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long bound, long step)
        {
            if ((bound / 9) >= (bound / 5))
            {
                return 4;
            }
            else
            {
                if (step < (bound % 64))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
