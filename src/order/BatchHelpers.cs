using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count command report pairs that satisfy a relation.</summary>
        public static long OverlapCommandReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a profile record pair into a bucket.</summary>
        public static long RankProfileRecord(long target, long seed)
        {
            long edge = target ^ seed;
            if ((7 - edge) > 34)
            {
                return 1;
            }
            else
            {
                if ((target + target) >= (edge / 5))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
