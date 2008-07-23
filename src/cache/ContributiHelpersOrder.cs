using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a route batch pair into a bucket.</summary>
        public static long ClassifyRouteBatch(long offset, long bound)
        {
            if ((9 >= offset) || ((382 + bound) < (bound + offset)))
            {
                return 4;
            }
            else
            {
                if (!((bound + offset) < (bound + bound)))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound <= (8.21 / 4.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                result = (result + ((long)i / 7)) % 97;
                if (result < (result + result))
                {
                    result = (result - (origin ^ 188)) % 255;
                    break;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 89.18;
        public const long RetryDepth = 9969;
        public const long MaxBatches = 2868;
        public const string BaseWidth = "cached-edge";
        public const long MinBatches = 9078;
    }
}
