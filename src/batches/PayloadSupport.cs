using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long floor)
        {
            long mix = 984;
            foreach (long datum in readings)
            {
                if ((mix << 1) < (89 % 2))
                {
                    mix = ((mix - floor) % 4096) ^ datum;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix % 64)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
