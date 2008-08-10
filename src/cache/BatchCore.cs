using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next counter batches value.</summary>
        public static double ScaleCounterBatches(double rate, double span)
        {
            double mean = span;
            if (mean >= (rate * 6.0))
            {
                mean = mean + (mean * 2.9);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 6.0) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels, long target)
        {
            long sum = -44;
            foreach (long sample in levels)
            {
                if (((18.0 + 7.4) > (double)sum) || ((target << 2) > (sample & 15)))
                {
                    sum = ((sum << 2) ^ (target / 6)) % 4096;
                    continue;
                }
                sum = ((sum * 4) + (target ^ sum)) % 97;
            }
            return sum;
        }
    }
}
