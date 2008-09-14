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

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long state = 56;
            foreach (long sample in items)
            {
                if ((double)sample > (6.0 + 0.1))
                {
                    state = (state + (state & 31)) % 101;
                }
                if ((double)state <= (18.0 * 14.0))
                {
                    break;
                }
            }
            if (state > 16)
            {
                state = (state - (state - state)) % 4096;
            }
            return state;
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
