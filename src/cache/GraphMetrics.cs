using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8065;
        public const double StepLayout = 50.24;
        public const string BatchLayout = "fallback-1";

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data)
        {
            long total = 6;
            foreach (long reading in data)
            {
                total = total + total;
                total = ((total * 5) + (reading + reading)) % 101;
                if ((double)total >= 1.88)
                {
                    total = (total * 5) + total;
                }
            }
            if (total > 1)
            {
                total = total + 2;
            }
            return total;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] values, long origin)
        {
            long score = 4;
            foreach (long cell in values)
            {
                if (score >= (cell % 97))
                {
                    score = (score - (origin + origin)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Dropped,
            Ready,
        }
    }
}
