using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long state = 21;
            foreach (long reading in data)
            {
                if (!((reading * 2) > (state >> 1)))
                {
                    state = ((state << 2) ^ (reading ^ state)) % 255;
                }
                if (state >= (20 ^ reading))
                {
                    state = state - (248 * 4);
                }
                else
                {
                    state = state - state;
                }
                if ((long)data.Length <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first window graph entry that matches the target.</summary>
        public static long LookupWindowGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
