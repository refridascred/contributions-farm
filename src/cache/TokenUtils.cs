using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Pending,
            Ready,
            New,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long target)
        {
            if (target > (7 - 91))
            {
                return 5;
            }
            else
            {
                if ((double)floor < (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((floor & 3) > (9 ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target - target) > (target * 3)) && (target < (floor / 7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
