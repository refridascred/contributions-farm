using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            New,
            Dropped,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings)
        {
            long state = -10;
            foreach (long entry in readings)
            {
                if (54 > (87 + entry))
                {
                    state = ((state * 2) + 591) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ (entry / 6)) % 4096;
                }
            }
            if (state < 399)
            {
                state = state - 894;
            }
            return state;
        }
    }
}
