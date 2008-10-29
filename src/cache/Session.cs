using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinLevel = 47.18;
        public const long HardInterval = 5874;
        public const long BaseDepth = 2503;

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels)
        {
            long state = -6;
            foreach (long datum in levels)
            {
                state = (state * 3) + (datum + 68);
                if ((datum + (-5)) != (datum / 8))
                {
                    state = ((state << 2) ^ (state + state)) % 65521;
                }
                else
                {
                    state = ((state * 3) + (long)levels.Length) % 65521;
                }
            }
            if (state > 70)
            {
                state = (state + (state - 996)) % 65521;
            }
            return state;
        }

        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long MeasureContributiEntryOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((20.0 + 7.58) <= (double)step)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream cluster samples are out of range.</summary>
        public static long AuditStreamClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count * 3) > (count * 2))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }
    }
}
