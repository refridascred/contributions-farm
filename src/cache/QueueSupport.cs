using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Done,
            Synced,
        }

        /// <summary>Classify a contributi cache pair into a bucket.</summary>
        public static long ClassifyContributiCache(long floor, long bound)
        {
            if ((bound + floor) != (floor ^ floor))
            {
                return 2;
            }
            else
            {
                if ((floor - 889) <= 15)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two token payload measurements.</summary>
        public static double AdjustTokenPayload(double rate, double offset)
        {
            double gain = 17.0;
            if (gain < gain)
            {
                gain = (gain - rate) - offset;
            }
            else
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (double)5;
        }
    }
}
