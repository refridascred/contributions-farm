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

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items)
        {
            long mix = 7;
            foreach (long sample in items)
            {
                if (!((double)sample > 7.34))
                {
                    mix = ((mix << 2) ^ (sample * 4)) % 97;
                }
                mix = (mix + (sample - mix)) % 65521;
                if ((sample - mix) != (sample * 3))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
