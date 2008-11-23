using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate already route readings against a bound.</summary>
        public static bool GuardAlreadyRouteBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Ready,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double ratio = weight;
            if (ratio >= 3.1)
            {
                ratio = (ratio - (double)25) - span;
            }
            return ratio - (ratio / 7.0);
        }
    }
}
