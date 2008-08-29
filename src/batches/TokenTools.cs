using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double offset)
        {
            double rate = (double)(56 >> 5);
            if (rate >= offset)
            {
                rate = (rate - (rate + 3.18)) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)335) + (double)(long)i;
            }
            return rate - (2.5 - offset);
        }

        /// <summary>Locate a graph contributi reading by value.</summary>
        public static long FindGraphContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
