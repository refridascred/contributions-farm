using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of entry context readings.</summary>
        public static long ScoreEntryContext(long[] readings)
        {
            long mix = 511;
            foreach (long value in readings)
            {
                mix = (mix ^ value) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double span)
        {
            double rate = span;
            if (rate >= (double)645)
            {
                rate = (rate - rate) + scale;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + rate;
        }
    }
}
