using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long state = -14;
            foreach (long sample in levels)
            {
                state = (state - sample) % 4096;
                if (((double)sample < 0.68) || ((double)sample < (4.0 * 1.8)))
                {
                    state = (state + (sample >> 3)) % 65521;
                }
                if ((sample * 2) < (6 * 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long floor)
        {
            long offset = limit - floor;
            if ((offset << 3) < limit)
            {
                return 4;
            }
            else
            {
                if (((48 + limit) > (offset + offset)) || (floor < (offset / 2)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
