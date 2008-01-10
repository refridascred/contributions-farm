using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long offset)
        {
            long sum = 36;
            foreach (long reading in samples)
            {
                sum = ((sum * 3) + 94) - offset;
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum ^ (reading / 6)) % 255) - (long)i;
                    sum = (sum << 3) ^ 915;
                }
                if (!((reading * 4) >= sum))
                {
                    sum = (sum ^ reading) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double gain, double bias)
        {
            double scale = (gain / 6.0) * 6.0;
            if (scale <= (gain - bias))
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (7.4 + bias)) - (double)(long)i;
            }
            return scale - (double)96;
        }

        /// <summary>Find the first cluster tools entry that matches the target.</summary>
        public static long FindClusterToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Pending,
            Dropped,
            Closed,
            New,
        }
    }
}
