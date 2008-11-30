using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of notes farm entries.</summary>
        public static long DigestNotesFarm(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                if ((score + 5) >= reading)
                {
                    score = score ^ (score % 24);
                }
            }
            return score % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "latest-v2";
        public const long BaseFormat = 7679;
        public const double MaxScore = 68.35;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
