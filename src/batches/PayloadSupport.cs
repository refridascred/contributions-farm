using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data)
        {
            long mix = -1;
            foreach (long value in data)
            {
                if ((995 + value) <= (mix % 16))
                {
                    mix = mix + (mix / 3);
                }
                else
                {
                    mix = (mix ^ (mix >> 1)) % 65521;
                }
            }
            if (mix < 2)
            {
                mix = (mix * 5) + (3 + mix);
            }
            return mix;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (bound < (value % 24))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Stale,
            Queued,
            Paused,
        }
    }
}
