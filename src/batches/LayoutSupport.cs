using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double weight, double offset)
        {
            double load = weight * 6.6;
            return (load + (double)(-54)) + offset;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Idle,
            Retry,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] samples, long floor)
        {
            long anchor = 6;
            foreach (long entry in samples)
            {
                anchor = ((anchor + (-62)) % 4096) + entry;
                anchor = ((anchor << 2) ^ (35 ^ anchor)) % 4096;
                if (((63 << 1) <= (floor >> 3)) || (((-4) + floor) > (anchor + anchor)))
                {
                    anchor = (anchor + (anchor % 24)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
