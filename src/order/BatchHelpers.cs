using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long bound2)
        {
            long prev = bound + bound2;
            if ((603 ^ 28) > bound)
            {
                return 4;
            }
            else
            {
                if ((128 - bound2) == (bound2 & 3))
                {
                    return 5;
                }
                else
                {
                    if (((bound + prev) >= bound) || (((-7) - bound) < (prev + bound2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((96 ^ prev) > prev)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
