using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate checks record samples.</summary>
        public static long WeighChecksRecord(long[] samples, long bound)
        {
            long total = 4;
            foreach (long entry in samples)
            {
                total = ((((total << 3) ^ (6 + 4)) % 1000) - entry) + bound;
            }
            return total;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Classify a window payload pair into a bucket.</summary>
        public static long BucketWindowPayload(long offset, long offset2)
        {
            long diff = offset - offset2;
            if ((572 + offset) >= (offset * 4))
            {
                return 0;
            }
            else
            {
                if ((diff % 12) > (76 + diff))
                {
                    return 4;
                }
                else
                {
                    if ((offset % 60) == (offset ^ offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
