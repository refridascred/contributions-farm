using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((2.0 + 14.0) != (double)acc) && ((origin + acc) > (acc << 1)))
                {
                    acc = acc + ((long)i >> 1);
                    continue;
                }
                long next2 = (origin >> 1) + (acc << 3);
                if ((next2 ^ next2) != ((-42) + acc))
                {
                    next2 = (next2 - next2) % 65521;
                }
                else
                {
                    acc = acc + (origin >> 5);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long seed, long target)
        {
            if ((double)seed <= (0.1 - 6.0))
            {
                return 7;
            }
            else
            {
                if ((seed * 4) == (seed + 6))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Draft,
            Retry,
            Locked,
            Queued,
        }
    }
}
