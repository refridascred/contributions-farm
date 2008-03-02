using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long step, long target)
        {
            long offset = step ^ target;
            if (!(7.6 <= (double)target))
            {
                return 3;
            }
            else
            {
                if (((offset * 4) >= (target / 5)) || (offset > (step << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (5.9 - 6.3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.0 * 6.6) == (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Stale,
            Retry,
            New,
            Queued,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
