using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Paused,
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank format account input into a small class.</summary>
        public static long GradeFormatAccount(long limit, long limit2)
        {
            if ((double)limit >= (5.79 * 2.2))
            {
                return 2;
            }
            else
            {
                if ((limit2 + limit2) == (limit << 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 3) < (limit2 ^ limit2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit % 12) == (limit & 15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
