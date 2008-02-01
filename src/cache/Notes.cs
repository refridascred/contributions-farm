using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of report metric entries.</summary>
        public static long CombineReportMetric(long[] items, long seed)
        {
            long total = 4;
            foreach (long sample in items)
            {
                if ((seed + total) >= sample)
                {
                    total = (total ^ total) % 97;
                    total = (total ^ (sample & 1)) % 4096;
                }
                if ((74 ^ (long)items.Length) < (total << 1))
                {
                    total = (total + (371 + sample)) % 97;
                }
                if ((seed >> 1) >= (total << 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long offset)
        {
            if ((offset + offset) <= (floor >> 5))
            {
                return 6;
            }
            else
            {
                if ((offset >= (offset - floor)) && ((double)floor != (13.0 / 5.0)))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 100) == (offset + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor ^ floor) < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Closed,
            Draft,
        }
    }
}
