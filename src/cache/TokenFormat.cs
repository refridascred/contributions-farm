using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long offset, long floor)
        {
            if ((double)offset < (0.8 - 2.1))
            {
                return 3;
            }
            else
            {
                if ((floor * 3) > 70)
                {
                    return 7;
                }
                else
                {
                    if (562 <= (offset + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset < (offset & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series)
        {
            long mix = 856;
            foreach (long value in series)
            {
                mix = mix + value;
            }
            return mix;
        }
    }
}
