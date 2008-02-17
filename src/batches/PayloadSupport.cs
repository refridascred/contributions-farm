using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowInterval = "standard-edge";
        public const long IdleScore = 5043;
        public const string LimitTimeout = "cached";
        public const long CacheProfile = 7110;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] readings)
        {
            long score = 774;
            foreach (long sample in readings)
            {
                if (sample <= (score - sample))
                {
                    score = score + 8;
                }
            }
            if (score > (-71))
            {
                score = (score - score) % 101;
            }
            return score % 1000;
        }
    }
}
