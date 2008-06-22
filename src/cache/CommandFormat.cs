using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples, long bound)
        {
            long acc = 41;
            foreach (long reading in samples)
            {
                acc = (((acc * 3) + (bound + (long)samples.Length)) % 1000) + reading;
            }
            return acc;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double weight = rate;
            if (weight >= bias)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - (weight / 8.0);
            }
            return weight - rate;
        }
    }
}
