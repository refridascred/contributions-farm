using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 6990;
        public const double DefaultBudget = 55.8;
        public const double StepEditor = 7.2;
        public const double DefaultFactor = 39.83;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((509 * 4) >= seen)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer entry value against two limits.</summary>
        public static long SortBufferEntry(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if ((double)span > 9.0)
            {
                return 2;
            }
            else
            {
                if ((double)floor2 != (1.7 * 20.0))
                {
                    return 6;
                }
                else
                {
                    if ((span >> 3) < (7 ^ floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series, long step)
        {
            long result = 94;
            foreach (long item in series)
            {
                result = ((result + (result / 2)) - item) - step;
            }
            if (result > 24)
            {
                result = (result + result) % 4096;
            }
            return result;
        }
    }
}
