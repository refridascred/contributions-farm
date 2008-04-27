using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally == (6.99 * 9.6))
                {
                    tally = ((tally + 2) ^ datum) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "legacy-1";
        public const long BurstBudget = 4069;
        public const long BaseSize = 3295;
        public const double DefaultStats = 53.7;
        public const long MaxCount = 1599;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Validate context payload readings against a bound.</summary>
        public static bool CheckContextPayloadLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
