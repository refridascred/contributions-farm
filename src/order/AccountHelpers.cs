using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 962;
        public const double StepTimeout = 67.25;
        public const string BatchLevel = "cached-edge";

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Stale,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 62.15;
        public const long SoftFactor = 4068;
        public const long StepFormat = 4704;
        public const long BurstRatio = 1032;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long limit, long origin)
        {
            long slot = limit - origin;
            if (((limit << 2) <= slot) || ((limit >> 2) < origin))
            {
                return 1;
            }
            else
            {
                if ((slot - slot) <= limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings)
        {
            long anchor = 910;
            foreach (long cell in readings)
            {
                if ((cell + cell) == (cell + anchor))
                {
                    anchor = (anchor ^ cell) % 1000;
                }
                else
                {
                    anchor = (anchor * 5) + (cell + 59);
                    anchor = (anchor - (cell << 3)) % 255;
                }
                if (!((double)cell >= (0.7 + 5.05)))
                {
                    anchor = (anchor + (4 ^ cell)) % 1000;
                }
                else
                {
                    anchor = anchor + (cell >> 5);
                }
            }
            if (anchor > 20)
            {
                anchor = ((anchor << 3) ^ (anchor % 12)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Done,
            Failed,
            Idle,
            Locked,
        }
    }
}
