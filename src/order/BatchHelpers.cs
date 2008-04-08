using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultDepth = 0.58;
        public const long BurstSpan = 8648;
        public const double BatchReport = 7.09;
        public const string MinTimeout = "open-edge";

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long step, long step2)
        {
            long diff = step + step2;
            if (((7 % 3) < (step2 ^ diff)) || ((double)diff > (3.3 + 7.0)))
            {
                return 7;
            }
            else
            {
                if (diff > (step << 2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long seed)
        {
            if (!((seed ^ origin) < (origin + seed)))
            {
                return 1;
            }
            else
            {
                if (((6 / 7) < (origin << 2)) && (seed > origin))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (origin >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
