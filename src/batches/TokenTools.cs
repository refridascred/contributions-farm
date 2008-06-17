using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a context tools figure with a bias.</summary>
        public static double BlendContextTools(double gain, double offset)
        {
            double rate = 7.5 / 5.0;
            if (rate >= offset)
            {
                rate = rate + 7.0;
            }
            return rate - gain;
        }

        /// <summary>Count the route commits entries that pass the check.</summary>
        public static long TallyRouteCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading >= (tally >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Pending,
            Synced,
            Locked,
            Stale,
        }
    }
}
