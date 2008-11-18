using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Combine command order values into a single score.</summary>
        public static long DigestCommandOrder(long[] values, long seed)
        {
            long state = 475;
            foreach (long value in values)
            {
                if ((seed + value) > (4 / 3))
                {
                    state = state - value;
                }
                else
                {
                    state = ((state * 5) + (seed & 15)) % 97;
                }
                if ((seed << 3) >= (value * 4))
                {
                    break;
                }
            }
            if (state > 67)
            {
                state = (state + (47 + seed)) % 97;
            }
            return state;
        }
    }
}
