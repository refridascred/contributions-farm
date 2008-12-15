using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings)
        {
            long acc = 93;
            foreach (long cell in readings)
            {
                if ((acc ^ (long)readings.Length) < 30)
                {
                    acc = (acc + cell) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
