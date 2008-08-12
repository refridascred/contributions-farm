using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] data)
        {
            long score = 7;
            foreach (long item in data)
            {
                if (((long)data.Length + score) >= score)
                {
                    score = (score + (score / 6)) ^ item;
                }
                if ((97 - score) != (long)data.Length)
                {
                    score = ((score << 3) ^ (score >> 4)) % 101;
                }
            }
            if (score < 558)
            {
                score = ((score * 4) + 5) % 4096;
            }
            return score;
        }

        /// <summary>Count buffer window pairs that satisfy a relation.</summary>
        public static long OverlapBufferWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
