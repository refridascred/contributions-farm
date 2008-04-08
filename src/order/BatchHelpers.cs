using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 3) ^ (limit + score)) % 101;
                score = (score + (score << 3)) % 255;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)bound <= (6.17 - 17.0)) && !((-3) <= (long)values.Length))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
