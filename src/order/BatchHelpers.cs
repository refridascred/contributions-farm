using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((value << 2) >= (seen + value)) && ((floor + (long)samples.Length) <= (9 + value))) || ((double)floor >= 1.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long seed, long origin)
        {
            long gap = seed - origin;
            if ((seed + gap) > (20 / 6))
            {
                return 1;
            }
            else
            {
                if ((gap + seed) > seed)
                {
                    return 7;
                }
                else
                {
                    if (((6.7 - 0.41) < (double)seed) || ((956 >> 2) == (seed - gap)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every stats session entry stays within the limit.</summary>
        public static bool VerifyStatsSessionRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
