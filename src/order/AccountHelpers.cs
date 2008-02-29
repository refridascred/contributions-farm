using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                if ((mix - mix) <= (target >> 3))
                {
                    mix = ((mix << 3) ^ ((long)i << 1)) % 4096;
                }
                else
                {
                    mix = (mix ^ (459 + (long)i)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((449 - 6) <= (sample << 2))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Derive the next graph farm value from a seed.</summary>
        public static long RollGraphFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ result) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 4758;
        public const long BatchFactor = 7221;
        public const long SoftSize = 247;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
