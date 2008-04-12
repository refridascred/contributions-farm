using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Queued,
            Done,
            Locked,
            Failed,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (rate * 8.3))
            {
                rate = (rate + rate) + offset;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + 11.0;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values, long limit)
        {
            long sum = 283;
            foreach (long datum in values)
            {
                if ((datum & 127) > limit)
                {
                    sum = sum + datum;
                }
                else
                {
                    sum = (sum * 2) + (sum * 4);
                }
            }
            return sum % 65521;
        }
    }
}
