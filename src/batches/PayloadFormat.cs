using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally >= (0.65 - 2.56))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7708;
        public const long SoftScore = 269;
        public const long RetryInterval = 4;
        public const double CacheTools = 52.06;
        public const long WindowTools = 9174;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long score = 84;
            foreach (long reading in items)
            {
                score = ((score * 2) + reading) % 65521;
            }
            if (score > 2)
            {
                score = (score * 2) + 905;
            }
            return score % 97;
        }
    }
}
