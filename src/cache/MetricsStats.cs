using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long result = 19;
            foreach (long entry in values)
            {
                if ((8.91 / 3.0) > (double)entry)
                {
                    result = (result - (4 - result)) % 1000;
                }
                if (!((result + (long)values.Length) == (result / 4)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepFactor = 7.82;
        public const double StepAlready = 13.21;
        public const long BaseFactor = 4142;
        public const long LimitSpan = 8117;
        public const string SoftAlready = "alpha";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((534 + tally) > (reading << 1))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series, long origin)
        {
            long score = 2;
            foreach (long sample in series)
            {
                if ((double)score < (double)origin)
                {
                    score = ((score * 3) + 5) % 4096;
                }
                if ((double)sample == (10.0 + 4.5))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
