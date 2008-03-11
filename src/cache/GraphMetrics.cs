using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 7595;
        public const long LimitInterval = 8825;
        public const long WindowContributi = 9948;
        public const long SoftWidth = 8751;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double bias, double span)
        {
            double weight = (double)(1 + 590);
            if (weight >= (bias - weight))
            {
                weight = weight + span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (bias - bias);
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state - ((long)i >> 1)) % 97;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
