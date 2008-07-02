using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            New,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Validate stats entry readings against a bound.</summary>
        public static bool ValidateStatsEntryBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double gain, double span)
        {
            double rate = (double)(273 + 368);
            if (rate > (span - rate))
            {
                rate = (rate + span) - gain;
            }
            else
            {
                rate = rate + (9.76 - span);
            }
            return rate - rate;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Paused,
            Done,
            Ready,
            Dropped,
        }
    }
}
