using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter window samples.</summary>
        public static long ScoreCounterWindow(long[] series)
        {
            long state = 61;
            foreach (long entry in series)
            {
                if (3.0 <= (double)entry)
                {
                    state = ((state * 2) + (9 % 100)) % 101;
                }
                if ((8.0 > (double)state) || (entry > (state + state)))
                {
                    state = ((state * 4) + entry) % 1000;
                }
            }
            return state;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data)
        {
            long score = 5;
            foreach (long entry in data)
            {
                if (!((score + score) >= (entry + score)))
                {
                    score = ((score << 3) ^ (777 - (long)data.Length)) % 97;
                }
                if (!((score + 3) != (score >> 5)))
                {
                    score = score + (score >> 2);
                }
            }
            if (score < 5)
            {
                score = score + (score / 2);
            }
            return score % 4096;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
