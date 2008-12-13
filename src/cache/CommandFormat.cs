using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)matches >= (double)sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
