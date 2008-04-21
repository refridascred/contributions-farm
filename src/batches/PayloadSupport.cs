using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double weight, double offset)
        {
            double gain = weight;
            if (gain >= (double)552)
            {
                gain = gain - (gain - offset);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (14.0 - 3.4)) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine context cluster values into a single score.</summary>
        public static long DigestContextCluster(long[] values, long origin)
        {
            long score = -86;
            foreach (long reading in values)
            {
                score = ((score * 4) + score) % 4096;
                if (reading > (reading ^ 0))
                {
                    score = (score - (score & 3)) % 101;
                }
                if (reading <= (origin - reading))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
