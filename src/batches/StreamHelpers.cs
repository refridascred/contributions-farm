using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double IdleTimeout = 71.47;
        public const double RetryWindow = 1.02;
        public const long SoftWindow = 4481;
        public const long IdleWindow = 1201;
        public const double HardSize = 91.8;

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double weight, double bias)
        {
            double gain = weight / 9.0;
            if (gain <= 2.3)
            {
                gain = (gain + (double)3) - bias;
            }
            return gain - weight;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 2264;
        public const long MinQueue = 2452;
        public const long HardQueue = 5732;
        public const long BurstQueue = 7619;
        public const double StepQueue = 27.15;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
