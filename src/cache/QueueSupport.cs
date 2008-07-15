using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double ratio = (scale / 5.0) + (offset - scale);
            if (ratio < ratio)
            {
                ratio = ratio - 3.0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (scale - 2.4)) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Ready,
            Pending,
            Done,
            Synced,
        }
    }
}
