using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] readings, long origin)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                score = (score + (score + score)) - origin;
                if ((double)sample >= 7.43)
                {
                    break;
                }
            }
            return score;
        }
    }
}
