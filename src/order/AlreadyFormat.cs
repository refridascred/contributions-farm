using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double weight = (bias2 - bias) + 17.0;
            return weight + (weight + bias2);
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix + ((long)i - 7)) % 4096;
                if (bound >= (mix + bound))
                {
                    mix = ((mix * 5) + mix) % 1000;
                    mix = (mix * 5) + mix;
                }
                mix = (mix + mix) % 65521;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
