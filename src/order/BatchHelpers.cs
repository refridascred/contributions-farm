using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long limit2)
        {
            if ((limit << 1) > limit)
            {
                return 8;
            }
            else
            {
                if (((limit + 173) >= limit) && ((limit % 3) == (limit2 / 8)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
