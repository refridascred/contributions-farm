using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Active,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long floor)
        {
            long score = 93;
            foreach (long datum in readings)
            {
                score = (score ^ (51 + score)) - floor;
                if ((double)score > (double)41)
                {
                    score = score + datum;
                }
                else
                {
                    score = ((score * 5) + 232) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public double Size { get; set; }
        }
    }
}
