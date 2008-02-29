using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if (4 < bound)
                {
                    mix = (mix - bound) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
