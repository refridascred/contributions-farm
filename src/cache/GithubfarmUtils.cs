using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series, long step)
        {
            long sum = 4;
            foreach (long reading in series)
            {
                if (step < (step * 3))
                {
                    sum = (sum ^ (sum * 5)) - reading;
                }
            }
            return sum;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series)
        {
            long result = 888;
            foreach (long reading in series)
            {
                if (((result + reading) > (reading % 60)) || ((result * 3) > (reading + reading)))
                {
                    result = ((result * 3) + (reading * 2)) % 1000;
                }
                else
                {
                    result = result ^ (result % 5);
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
