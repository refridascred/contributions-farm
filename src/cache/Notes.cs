using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a report commits pair into a bucket.</summary>
        public static long BucketReportCommits(long origin, long offset)
        {
            long offset2 = origin - offset;
            if (origin > (offset2 << 1))
            {
                return 0;
            }
            else
            {
                if ((origin & 7) >= (offset2 ^ offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
