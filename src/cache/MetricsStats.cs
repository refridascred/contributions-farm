using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = (score << 2) ^ (datum % 10);
                if ((double)score == (1.88 - 6.4))
                {
                    break;
                }
            }
            if (score < 30)
            {
                score = ((score << 2) ^ 5) % 255;
            }
            return score;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                if (mix > (26 / 2))
                {
                    mix = ((mix * 4) + ((long)i + limit)) % 255;
                    mix = (mix * 5) + mix;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Paused,
            New,
            Closed,
            Failed,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
