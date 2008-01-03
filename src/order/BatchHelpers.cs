using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long offset)
        {
            long anchor = -44;
            foreach (long cell in readings)
            {
                if (((19 - offset) >= (cell >> 5)) || ((anchor - anchor) == (anchor % 5)))
                {
                    anchor = anchor - offset;
                }
                anchor = (anchor - (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
