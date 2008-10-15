using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double weight, double offset)
        {
            double mean = weight / 9.0;
            return (mean + (5.0 / 9.0)) + offset;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 925;
        public const long BaseEditor = 1088;
        public const long SoftScore = 2068;

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items, long origin)
        {
            long result = 178;
            foreach (long reading in items)
            {
                if ((77 - 2) >= ((long)items.Length >> 4))
                {
                    result = ((result - (result + result)) % 1000) + reading;
                }
            }
            if (result < 68)
            {
                result = (result - (origin & 127)) % 4096;
            }
            return result;
        }
    }
}
