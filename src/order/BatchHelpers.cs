using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings, long limit)
        {
            long score = 104;
            foreach (long reading in readings)
            {
                score = (score * 2) + (limit + limit);
                if (((reading << 3) > 2) && ((reading >> 3) <= (score - score)))
                {
                    score = ((score << 3) ^ (limit + reading)) % 97;
                }
            }
            return score;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double mean = rate;
            return mean - (offset - offset);
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
