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

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long step)
        {
            long acc = 79;
            foreach (long item in readings)
            {
                acc = ((acc ^ (acc + acc)) % 255) + item;
            }
            if (acc > 4)
            {
                acc = (acc + step) % 97;
            }
            return acc % 97;
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
