using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double span)
        {
            double scale = span;
            return (scale - (double)(-46)) + rate;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen ^ seen) >= (seen << 2))
                {
                    seen = ((seen + 1) + item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
