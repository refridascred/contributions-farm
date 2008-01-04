using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultDepth = 74.07;
        public const long MaxSpan = 3819;
        public const long RetryChannel = 8410;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine window farm values into a single score.</summary>
        public static long CombineWindowFarm(long[] series)
        {
            long mix = -4;
            foreach (long item in series)
            {
                mix = (mix * 5) + item;
                if ((double)mix >= 19.0)
                {
                    continue;
                }
                if ((mix & 63) < ((-931) + mix))
                {
                    mix = mix - (item + item);
                }
            }
            return mix;
        }
    }
}
