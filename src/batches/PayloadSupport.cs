using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Closed,
            New,
        }

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
