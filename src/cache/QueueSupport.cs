using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double weight, double span)
        {
            double drift = (weight - span) / 6.0;
            if (drift <= 2.32)
            {
                drift = drift - (weight / 5.0);
            }
            return drift - 5.9;
        }

        /// <summary>Combine session graph values into a single score.</summary>
        public static long FoldSessionGraph(long[] readings, long limit)
        {
            long score = 27;
            foreach (long cell in readings)
            {
                if ((cell ^ cell) < limit)
                {
                    score = (score + (limit + (-930))) % 1000;
                }
            }
            if (score > 0)
            {
                score = (score - (score + limit)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
