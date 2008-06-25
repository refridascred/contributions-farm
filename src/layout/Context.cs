using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Closed,
            New,
            Pending,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two token tools measurements.</summary>
        public static double SmoothTokenTools(double bias, double offset)
        {
            double bias2 = (double)(-124) + (bias / 4.0);
            return (bias2 - (double)96) + offset;
        }
    }
}
