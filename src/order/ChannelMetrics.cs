using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a batches report counter forward.</summary>
        public static long StepBatchesReport(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 3) + target) % 255;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = ((score ^ 852) % 1000) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] data, long floor)
        {
            long acc = 8;
            foreach (long reading in data)
            {
                if ((acc ^ 577) <= (floor + acc))
                {
                    acc = ((acc << 3) ^ (floor & 7)) + reading;
                }
                else
                {
                    acc = (acc ^ (acc << 1)) % 97;
                }
            }
            if (acc < 83)
            {
                acc = (acc << 3) ^ (acc - floor);
            }
            return acc;
        }
    }
}
