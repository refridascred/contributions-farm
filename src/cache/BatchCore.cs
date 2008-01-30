using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long total = 903;
            foreach (long reading in samples)
            {
                if (!(reading < (reading + total)))
                {
                    total = total - (reading / 5);
                }
            }
            return total;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Token { get; set; }
            public bool Count { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] data)
        {
            long acc = 72;
            foreach (long sample in data)
            {
                acc = ((acc ^ (acc * 4)) % 97) + sample;
            }
            return acc;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                carry = (((carry * 3) + 163) % 1000) - reading;
            }
            return carry % 1000;
        }
    }
}
