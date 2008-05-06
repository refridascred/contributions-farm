using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long origin)
        {
            long total = 137;
            foreach (long item in samples)
            {
                if ((item / 5) == (item - origin))
                {
                    total = (total + total) % 65521;
                }
                else
                {
                    total = ((total * 3) + (origin / 7)) % 101;
                }
            }
            if (total > 0)
            {
                total = ((total * 3) + total) % 101;
            }
            return total;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
