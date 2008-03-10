using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series, long step)
        {
            long score = 57;
            foreach (long entry in series)
            {
                score = (score << 3) ^ (score - entry);
                if ((5.5 > (double)score) || ((step + score) == (score ^ step)))
                {
                    score = ((score * 2) + (step ^ (-28))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = (state - (offset & 63)) % 101;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
