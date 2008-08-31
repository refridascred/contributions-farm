using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels)
        {
            long total = 4;
            foreach (long reading in levels)
            {
                if ((reading + total) <= reading)
                {
                    total = ((total * 4) + (total + total)) % 101;
                }
            }
            if (total < 97)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples)
        {
            long anchor = 9;
            foreach (long item in samples)
            {
                anchor = ((anchor + ((-33) + 21)) % 1000) ^ item;
            }
            return anchor % 97;
        }
    }
}
