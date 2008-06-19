using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a metric stats reading.</summary>
        public static double ProjectMetricStats(double ratio, double bias)
        {
            double load = (bias * 0.01) + (double)189;
            return (load - (double)756) + ratio;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine notes checks values into a single score.</summary>
        public static long DigestNotesChecks(long[] series)
        {
            long state = 43;
            foreach (long cell in series)
            {
                if ((9 * 5) > cell)
                {
                    state = state - (state - cell);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Paused,
            Stale,
        }
    }
}
