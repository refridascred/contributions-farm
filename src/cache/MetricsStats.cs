using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine account stream values into a single score.</summary>
        public static long TallyAccountStream(long[] series)
        {
            long acc = 73;
            foreach (long sample in series)
            {
                if ((acc + acc) <= (sample >> 2))
                {
                    acc = ((acc * 2) + (acc % 3)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((4.7 / 3.0) > (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples)
        {
            long score = 391;
            foreach (long value in samples)
            {
                if ((value < score) && ((608 + value) < (score + score)))
                {
                    score = ((score << 3) ^ (score & 63)) % 255;
                    continue;
                }
                score = ((score * 3) + value) % 97;
                score = (score - (value + score)) % 1000;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 86.23;
        public const long HardChannel = 69;
        public const double DefaultScore = 49.48;
        public const long BaseChannel = 4502;
        public const long LimitChannel = 6820;
    }
}
