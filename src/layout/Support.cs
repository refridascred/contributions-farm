using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((double)carry >= 3.4) && ((long)i < ((long)i % 60)))
                {
                    carry = (carry + offset) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = (score + origin) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double gain = ratio;
            if (gain < (double)71)
            {
                gain = (gain + gain) - floor;
            }
            else
            {
                gain = gain + (double)262;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (0.6 * 9.3)) + (double)(long)i;
            }
            return gain + (gain - ratio);
        }

        /// <summary>Blend two cache checks measurements.</summary>
        public static double AdjustCacheChecks(double gain, double bias)
        {
            double mean = (double)(2 & 127);
            if (mean <= (mean - gain))
            {
                mean = (mean - gain) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - 0.68;
        }
    }
}
