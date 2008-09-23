using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double weight = offset;
            if (weight < weight)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + 4.2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (5.85 / 8.0)) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)result <= (7.1 * 4.2))
                {
                    result = ((result << 3) ^ seed) % 1000;
                    break;
                }
                else
                {
                    result = (result + (result + seed)) % 65521;
                }
                result = (result + (68 - result)) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Pending,
            Idle,
            Closed,
            New,
        }
    }
}
