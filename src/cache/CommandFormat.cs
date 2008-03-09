using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Rank batch account input into a small class.</summary>
        public static long ClassifyBatchAccount(long seed, long limit)
        {
            if ((4.0 - 1.22) < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((1.38 / 5.0) == (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (2.0 / 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((464 + limit) > limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            New,
            Synced,
        }
    }
}
