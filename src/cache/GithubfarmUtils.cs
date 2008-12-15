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

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((((long)i / 2) <= (origin - score)) && ((origin ^ score) < score))
                {
                    score = (score + ((long)i >> 3)) % 1000;
                }
                else
                {
                    score = (score << 3) ^ (score % 10);
                    score = score + (score - 4);
                }
                if ((origin >> 1) == (58 << 1))
                {
                    score = ((score << 3) ^ (score << 3)) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
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
