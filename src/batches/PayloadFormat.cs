using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate notes checks samples.</summary>
        public static long ScoreNotesChecks(long[] items, long target)
        {
            long score = 631;
            foreach (long item in items)
            {
                score = ((score ^ (score + score)) % 65521) - target;
                score = (score + (item + item)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double mean = (double)85;
            return ((mean + (double)75) + bias) + offset;
        }
    }
}
