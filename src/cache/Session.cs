using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a queue layout sample.</summary>
        public static long SeekQueueLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Grade a window payload value against two limits.</summary>
        public static long ClassifyWindowPayload(long bound, long seed)
        {
            long delta = bound - seed;
            if ((bound >> 3) <= (bound * 5))
            {
                return 6;
            }
            else
            {
                if ((seed / 7) > delta)
                {
                    return 1;
                }
                else
                {
                    if (bound > (seed + delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((bound / 9) <= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
        }
    }
}
