using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double weight = (floor - gain) + gain;
            return weight + (13.0 * 9.85);
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public bool Score { get; set; }
        }
    }
}
