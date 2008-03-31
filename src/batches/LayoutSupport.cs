using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
