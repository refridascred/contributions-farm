using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "latest";
        public const long HardSupport = 2588;
        public const string RetryCount = "alpha-v2";
        public const long BurstRatio = 900;
        public const long WindowSupport = 2301;

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels, long bound)
        {
            long score = 660;
            foreach (long datum in levels)
            {
                score = (((score * 5) + (score + bound)) % 255) + datum;
            }
            return score % 4096;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
