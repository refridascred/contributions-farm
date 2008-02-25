using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a graph cache figure with a bias.</summary>
        public static double ScaleGraphCache(double bias, double floor)
        {
            double gain = floor;
            if (gain >= (double)842)
            {
                gain = (gain + 12.0) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + floor) - (double)(long)i;
            }
            return gain - (floor / 4.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowWidth = "staging-v2";
        public const long MinSpan = 5758;
        public const long RetryBuffer = 5108;
        public const long MinBuffer = 7898;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            New,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Classify a entry token pair into a bucket.</summary>
        public static long GradeEntryToken(long bound, long origin)
        {
            if ((origin >> 4) <= 9)
            {
                return 7;
            }
            else
            {
                if ((96 / 5) < origin)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine route metrics values into a single score.</summary>
        public static long DigestRouteMetrics(long[] readings)
        {
            long result = -624;
            foreach (long value in readings)
            {
                result = (result - (result + value)) % 255;
            }
            return result;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
