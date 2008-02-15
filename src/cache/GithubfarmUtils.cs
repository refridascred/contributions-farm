using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)sum < (1.93 * 6.53))
                {
                    sum = ((sum * 3) + (long)i) % 1000;
                }
                if ((target - target) <= (sum + target))
                {
                    sum = (sum - ((-5) + target)) % 65521;
                }
                if (target > (sum + sum))
                {
                    sum = sum - ((long)i & 1);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i * 2) <= ((long)i + bound))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
