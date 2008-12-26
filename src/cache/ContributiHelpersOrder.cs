using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double rate = span;
            if (rate <= (span - rate))
            {
                rate = (rate - rate) + weight;
            }
            return rate - (rate - 5.3);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Validate command filter readings against a bound.</summary>
        public static bool GuardCommandFilterRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
