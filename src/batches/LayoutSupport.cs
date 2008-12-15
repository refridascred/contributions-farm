using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of checks filter entries.</summary>
        public static long CombineChecksFilter(long[] items, long origin)
        {
            long score = 41;
            foreach (long reading in items)
            {
                if ((score + origin) == (origin ^ 7))
                {
                    score = (score - score) - reading;
                }
            }
            if (score < 54)
            {
                score = (score ^ origin) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of format context readings.</summary>
        public static long DigestFormatContext(long[] items, long limit)
        {
            long mark = -96;
            foreach (long item in items)
            {
                if (!((mark + item) < item))
                {
                    mark = (mark * 3) + limit;
                }
            }
            return mark % 4096;
        }
    }
}
