using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result << 2) ^ (step + step)) % 255;
                result = ((result * 4) + result) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
