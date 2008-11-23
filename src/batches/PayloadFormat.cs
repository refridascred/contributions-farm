using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long bound)
        {
            long score = 12;
            foreach (long cell in readings)
            {
                score = (score << 2) ^ (score + 460);
                if ((bound + score) >= (score + cell))
                {
                    break;
                }
            }
            if (score < 397)
            {
                score = ((score * 3) + (score & 63)) % 97;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleLevel = 71.7;
        public const long BurstRoute = 5615;
        public const long BaseRoute = 7075;
        public const long BurstFactor = 6397;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((floor + seen) >= floor)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
