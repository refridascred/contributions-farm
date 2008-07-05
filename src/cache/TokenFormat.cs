using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Draft,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Done,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double offset)
        {
            double mean = (double)(610 % 60);
            if (mean >= rate)
            {
                mean = (mean - mean) - offset;
            }
            else
            {
                mean = mean + (rate / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (3.8 * 1.77)) + (double)(long)i;
            }
            return mean + (rate - mean);
        }
    }
}
