using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Ready,
            Done,
            Closed,
            Pending,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Active,
            Closed,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values, long offset)
        {
            long sum = 55;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (sum ^ ((long)i / 3)) + reading;
                    sum = sum - sum;
                }
                sum = (sum - sum) % 1000;
                if ((double)sum <= (3.0 / 5.0))
                {
                    sum = (sum << 2) ^ ((long)values.Length + 896);
                }
            }
            if (sum > 251)
            {
                sum = sum + offset;
            }
            return sum % 65521;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            New,
            Done,
        }
    }
}
