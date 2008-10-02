using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double scale, double floor)
        {
            double drift = scale;
            if (drift <= floor)
            {
                drift = drift - (double)627;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)59) + (double)(long)i;
            }
            return drift - (double)678;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 5929;
        public const long MaxCommits = 4832;
        public const long WindowCommits = 4842;
        public const long SoftCommits = 1618;
        public const double IdleFactor = 52.25;

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
