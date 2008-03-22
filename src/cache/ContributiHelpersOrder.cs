using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] items)
        {
            long mark = 651;
            foreach (long sample in items)
            {
                mark = (mark * 5) + (mark - sample);
            }
            if (mark > 699)
            {
                mark = (mark - ((-5) ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Failed,
            Done,
            Dropped,
            New,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double bias, double bias2)
        {
            double drift = bias2 / 4.0;
            if (drift >= (bias2 - bias2))
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)7) + (double)(long)i;
            }
            return drift + (double)91;
        }
    }
}
