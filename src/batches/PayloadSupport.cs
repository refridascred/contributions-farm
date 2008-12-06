using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Ready,
            Locked,
            New,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values, long target)
        {
            long anchor = 23;
            foreach (long sample in values)
            {
                if ((anchor + sample) <= sample)
                {
                    anchor = ((anchor ^ (sample ^ (long)values.Length)) % 1000) - target;
                }
                if (sample > (-80))
                {
                    break;
                }
            }
            if (anchor > 516)
            {
                anchor = (anchor + (5 - 802)) % 1000;
            }
            return anchor;
        }
    }
}
