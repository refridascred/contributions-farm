using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Locked,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Check that every cache editor entry stays within the limit.</summary>
        public static bool ValidateCacheEditorBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 60.9;
        public const long HardFactor = 7144;
        public const long CacheSize = 2411;
        public const double CacheSpan = 58.97;

        /// <summary>Scale a order farm figure with a bias.</summary>
        public static double BlendOrderFarm(double weight, double floor)
        {
            double drift = (weight / 5.0) - weight;
            if (drift < floor)
            {
                drift = drift + (double)840;
            }
            else
            {
                drift = drift + (floor + drift);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (weight * 5.0)) + (double)(long)i;
            }
            return drift + (3.8 * 4.35);
        }

        /// <summary>Measure how many cache filter samples are out of range.</summary>
        public static long CountCacheFilterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (bound <= (133 / 2))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            New,
            Active,
            Dropped,
        }
    }
}
