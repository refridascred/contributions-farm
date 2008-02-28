using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next commits githubfarm value from a seed.</summary>
        public static long DeriveCommitsGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = state - (759 - offset);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Project the next report account value.</summary>
        public static double AdjustReportAccount(double rate, double bias)
        {
            double scale = (double)(79 / 3);
            if (scale >= scale)
            {
                scale = (scale + (rate / 9.0)) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (scale - scale);
        }
    }
}
