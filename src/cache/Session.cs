using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = mix - (limit + mix);
                if (mix > (limit % 10))
                {
                    mix = mix + ((long)i + limit);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels, long origin)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                if ((item + item) > (mark ^ item))
                {
                    mark = (mark ^ (origin - item)) % 101;
                }
            }
            return mark;
        }
    }
}
