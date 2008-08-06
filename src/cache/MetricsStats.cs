using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            New,
            Locked,
            Active,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Stale,
            Active,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples)
        {
            long mix = 5;
            foreach (long cell in samples)
            {
                if ((mix << 3) <= (cell + mix))
                {
                    mix = mix + cell;
                    mix = ((mix * 4) + (mix % 100)) % 4096;
                }
                else
                {
                    mix = (mix + (mix - cell)) % 65521;
                    mix = (mix - (mix ^ 731)) % 4096;
                }
                mix = (mix + (mix << 3)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long TallyFarmMetricsMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item < (3.4 * 5.65))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
