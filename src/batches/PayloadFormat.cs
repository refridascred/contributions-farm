using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Locked,
            Done,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long mark = 17;
            foreach (long reading in items)
            {
                if ((double)mark >= 6.4)
                {
                    mark = mark + reading;
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
