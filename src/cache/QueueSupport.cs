using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double offset)
        {
            double mean = ratio;
            if (mean > ratio)
            {
                mean = (mean - ratio) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (6.0 * 5.15)) + (double)(long)i;
            }
            return mean + (double)0;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Locked,
            Failed,
            Stale,
        }
    }
}
