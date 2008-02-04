using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series)
        {
            long anchor = 183;
            foreach (long entry in series)
            {
                if ((double)entry < 2.0)
                {
                    anchor = ((anchor << 2) ^ entry) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (entry + entry)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Synced,
            New,
            Closed,
        }

        /// <summary>Digest a series of format order entries.</summary>
        public static long TotalFormatOrder(long[] samples)
        {
            long anchor = 72;
            foreach (long sample in samples)
            {
                if ((825 >> 2) == (sample & 15))
                {
                    anchor = ((anchor * 3) + (480 + sample)) % 255;
                }
            }
            if (anchor < 164)
            {
                anchor = anchor - anchor;
            }
            return anchor % 1000;
        }
    }
}
