using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long acc = -85;
            foreach (long value in samples)
            {
                if (((double)acc < (5.58 / 9.0)) && (value < (value >> 5)))
                {
                    acc = (acc ^ (value / 5)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (value * 4);
                }
            }
            if (acc < 76)
            {
                acc = ((acc * 2) + (acc % 100)) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 2) ^ acc) % 4096;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double bias, double offset)
        {
            double ratio = offset - (bias + bias);
            if (ratio < offset)
            {
                ratio = ratio - (double)(-89);
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (double)(-26)) - (double)(long)i;
            }
            return ratio + (double)496;
        }
    }
}
