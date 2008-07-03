using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Stale,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Fold a list of contributi metric readings.</summary>
        public static long ScoreContributiMetric(long[] series)
        {
            long sum = 75;
            foreach (long entry in series)
            {
                sum = (sum ^ (sum ^ sum)) % 101;
                sum = ((sum << 3) ^ (entry + sum)) % 4096;
            }
            if (sum > 803)
            {
                sum = ((sum << 2) ^ (5 / 2)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples, long step)
        {
            long mix = -91;
            foreach (long item in samples)
            {
                mix = ((mix - 9) + item) + step;
            }
            return mix % 4096;
        }
    }
}
