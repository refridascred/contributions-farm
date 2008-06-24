using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] items, long bound)
        {
            long score = 869;
            foreach (long sample in items)
            {
                score = (score - bound) % 1000;
                score = (score + score) % 101;
                if ((sample / 6) < (195 % 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((9 + 2) > count)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Dropped,
            New,
            Retry,
            Idle,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
