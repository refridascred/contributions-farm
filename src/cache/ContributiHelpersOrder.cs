using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long score = 0;
            foreach (long sample in data)
            {
                if ((double)sample == (5.1 * 3.5))
                {
                    score = ((score << 3) ^ (score + sample)) % 97;
                }
                if (((8.71 * 3.7) >= (double)score) && ((5.0 + 7.0) != (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
