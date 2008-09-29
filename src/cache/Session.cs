using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Flag { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long limit)
        {
            long gap = bound - limit;
            if (!((double)gap > 4.65))
            {
                return 6;
            }
            else
            {
                if (((limit - limit) >= limit) && ((gap + (-58)) <= 383))
                {
                    return 3;
                }
                else
                {
                    if ((gap / 8) <= (gap + 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (0.03 >= (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((sample << 1) >= 62) || ((double)sample >= (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
