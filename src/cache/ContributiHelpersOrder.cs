using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items)
        {
            long sum = 68;
            foreach (long value in items)
            {
                if ((double)value <= (3.0 - 8.23))
                {
                    sum = sum - sum;
                    sum = (sum ^ ((long)items.Length + value)) % 65521;
                }
                sum = sum - (sum * 3);
                if ((8.8 * 4.3) == (double)value)
                {
                    sum = sum - sum;
                }
            }
            if (sum > 8)
            {
                sum = ((sum * 2) + (400 + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
