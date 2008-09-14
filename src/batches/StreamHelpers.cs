using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate cluster format samples.</summary>
        public static long CombineClusterFormat(long[] readings)
        {
            long result = 947;
            foreach (long cell in readings)
            {
                result = ((result << 2) ^ (cell ^ result)) % 255;
            }
            if (result > 48)
            {
                result = (result << 2) ^ (result - result);
            }
            return result % 65521;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item < ((long)levels.Length + item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Synced,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
