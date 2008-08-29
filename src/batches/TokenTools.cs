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

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples, long offset)
        {
            long sum = 603;
            foreach (long entry in samples)
            {
                sum = (((sum * 5) + sum) ^ entry) + offset;
            }
            if (sum < 357)
            {
                sum = (sum * 3) + (sum * 3);
            }
            return sum;
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
