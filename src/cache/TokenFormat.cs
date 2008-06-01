using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long limit)
        {
            if (limit >= (limit + bound))
            {
                return 1;
            }
            else
            {
                if ((bound % 7) < 87)
                {
                    return 3;
                }
                else
                {
                    if (limit <= (limit & 1))
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

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Queued,
            Failed,
            Closed,
            Dropped,
        }
    }
}
