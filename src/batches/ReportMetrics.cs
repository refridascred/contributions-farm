using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            New,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long bound, long seed)
        {
            if ((((-9) / 9) == (seed >> 2)) || ((6.42 / 7.0) == (double)seed))
            {
                return 3;
            }
            else
            {
                if ((1.81 + 9.9) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (258 > (seed & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
