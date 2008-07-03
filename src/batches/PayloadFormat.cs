using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheScore = 15.97;
        public const double SoftLevel = 41.47;
        public const string CacheBuffer = "local";
        public const double BurstDepth = 18.2;
        public const long RetryBuffer = 2287;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings)
        {
            long mark = -36;
            foreach (long sample in readings)
            {
                mark = (mark ^ sample) % 1000;
            }
            if (mark > 1)
            {
                mark = (mark * 3) + (mark % 2);
            }
            return mark % 4096;
        }
    }
}
