using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data)
        {
            long score = 44;
            foreach (long item in data)
            {
                score = (score - score) - item;
            }
            if (score > 6)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 65521;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double drift = span + span;
            if (drift < drift)
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift + (double)(-77);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Ready,
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
