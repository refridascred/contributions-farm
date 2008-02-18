using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            New,
            Draft,
            Dropped,
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double drift = (double)544 - scale;
            if (drift < 8.6)
            {
                drift = drift + (scale - offset);
            }
            else
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (offset / 3.0)) + (double)(long)i;
            }
            return drift - (double)7;
        }

        /// <summary>Validate layout queue readings against a bound.</summary>
        public static bool CheckLayoutQueueBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double scale = (double)(538 + (-306));
            return (scale - (ratio / 5.0)) + bias;
        }
    }
}
