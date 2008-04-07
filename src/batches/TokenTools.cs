using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
