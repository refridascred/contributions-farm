using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
