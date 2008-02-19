using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a already filter figure with a bias.</summary>
        public static double BlendAlreadyFilter(double scale, double offset)
        {
            double weight = (scale * 6.0) * 9.0;
            if (weight < offset)
            {
                weight = weight + (double)71;
            }
            else
            {
                weight = weight - (weight * 5.0);
            }
            return weight + (weight / 8.0);
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Paused,
            Done,
        }
    }
}
