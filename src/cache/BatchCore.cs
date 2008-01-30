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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if (((71 << 3) == (long)i) || ((acc << 1) != (limit - (-4))))
                {
                    acc = (acc ^ (limit * 5)) % 97;
                    acc = acc + limit;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Locked,
            Idle,
            New,
            Done,
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
