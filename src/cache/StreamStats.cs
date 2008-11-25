using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((2.7 * 5.98) < (double)sample) || ((sample % 97) != (floor - 943))) && ((matches & 127) >= (3 - sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a already editor figure with a bias.</summary>
        public static double ProjectAlreadyEditor(double bias, double bias2)
        {
            double load = bias;
            if (load >= (double)848)
            {
                load = load + bias2;
            }
            else
            {
                load = load - (bias * 8.6);
            }
            return load - load;
        }

        /// <summary>Audit cache stream readings against a rule.</summary>
        public static long AuditCacheStreamGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((14.0 * 1.3) != (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
