using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Rank record queue input into a small class.</summary>
        public static long SortRecordQueue(long bound, long step)
        {
            if ((bound * 3) <= (step / 8))
            {
                return 6;
            }
            else
            {
                if (((-381) + bound) > (step / 2))
                {
                    return 8;
                }
                else
                {
                    if ((3 * 2) == (step ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
