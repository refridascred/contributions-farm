using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Done,
            New,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long state = -255;
            foreach (long cell in data)
            {
                if ((seed % 24) <= (state ^ cell))
                {
                    state = ((state * 2) + (seed + seed)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Grade a cluster token value against two limits.</summary>
        public static long ClassifyClusterToken(long offset, long limit)
        {
            if (((limit << 2) >= (limit & 1)) || ((double)offset <= (4.39 - 1.75)))
            {
                return 3;
            }
            else
            {
                if ((offset <= (offset / 5)) && (limit <= (offset + offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((limit / 7) <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
