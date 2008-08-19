using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Synced,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long step)
        {
            if ((double)step > (double)limit)
            {
                return 4;
            }
            else
            {
                if (((step & 15) <= (step + (-3))) || (step > (limit - step)))
                {
                    return 8;
                }
                else
                {
                    if (8.33 > (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor filter sample.</summary>
        public static long FindEditorFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
