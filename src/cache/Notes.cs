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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long step, long limit)
        {
            if ((limit + (-8)) >= (limit - step))
            {
                return 6;
            }
            else
            {
                if ((limit % 3) <= (limit >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((step - limit) > (limit & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((502 / 8) != ((-37) + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
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
