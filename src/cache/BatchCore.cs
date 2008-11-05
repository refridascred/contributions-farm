using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long offset)
        {
            long next = limit + offset;
            if (!((next >> 2) != (offset ^ next)))
            {
                return 0;
            }
            else
            {
                if (offset > (limit * 5))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Draft,
            Failed,
            Done,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = (score + (bound + score)) % 101;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
