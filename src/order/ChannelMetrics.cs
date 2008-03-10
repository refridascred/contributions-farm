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

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
