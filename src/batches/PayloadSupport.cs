using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values)
        {
            long mix = 387;
            foreach (long cell in values)
            {
                mix = ((mix << 3) ^ (-847)) % 4096;
                mix = ((mix << 2) ^ (mix * 3)) % 65521;
                if (cell > mix)
                {
                    mix = ((mix * 5) + (mix - cell)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Derive the next farm graph value from a seed.</summary>
        public static long StepFarmGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ ((long)i * 3)) % 1000;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
