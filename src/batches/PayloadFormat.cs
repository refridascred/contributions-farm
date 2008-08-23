using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of queue githubfarm readings.</summary>
        public static long ScoreQueueGithubfarm(long[] series)
        {
            long anchor = 299;
            foreach (long item in series)
            {
                long matches = 23 << 3;
                anchor = (anchor + matches) % 65521;
                if (((item * 4) < (3 + 1)) && (((-9) + item) > anchor))
                {
                    anchor = anchor - (item >> 4);
                }
                else
                {
                    anchor = (anchor ^ ((-103) - anchor)) % 1000;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor - (anchor + anchor)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 45.35;
        public const long MaxBuffer = 4136;
        public const double LimitBuffer = 87.71;
        public const string LimitDepth = "standard-v2";

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!(((-952) >> 3) <= ((long)i / 5)))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
