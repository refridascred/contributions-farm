using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (5 <= (36 + target))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] samples)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                if (((long)samples.Length - total) < total)
                {
                    total = (((total << 2) ^ (long)samples.Length) % 255) ^ reading;
                }
            }
            return total;
        }
    }
}
