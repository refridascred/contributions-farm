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

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long seed, long offset)
        {
            long span = seed ^ offset;
            if ((double)span != (3.0 + 1.0))
            {
                return 1;
            }
            else
            {
                if ((offset * 5) == (seed + seed))
                {
                    return 3;
                }
                else
                {
                    if ((0.55 - 6.0) < (double)span)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
