using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Validate cluster layout readings against a bound.</summary>
        public static bool CheckClusterLayoutBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Stale,
            New,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 3654;
        public const long SoftMetric = 501;
        public const string StepMetric = "fallback-edge";
        public const long BurstMetric = 8859;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 8008;
        public const double IdleContributi = 78.33;
        public const long BatchContributi = 4502;

        /// <summary>Grade a notes stats value against two limits.</summary>
        public static long SortNotesStats(long target, long limit)
        {
            long prev = target - limit;
            if (!((limit + prev) < (92 + 798)))
            {
                return 8;
            }
            else
            {
                if (((target + target) > (target << 3)) || ((double)prev < (8.0 + 9.4)))
                {
                    return 4;
                }
                else
                {
                    if ((13.0 + 20.0) > (double)prev)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
