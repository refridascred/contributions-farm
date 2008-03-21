using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series)
        {
            long total = 67;
            foreach (long sample in series)
            {
                total = ((total + 60) % 1000) + sample;
            }
            if (total > (-285))
            {
                total = total + total;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of batches stats readings.</summary>
        public static long TotalBatchesStats(long[] readings)
        {
            long acc = 95;
            foreach (long value in readings)
            {
                if ((value / 9) == (5 << 3))
                {
                    acc = (acc + acc) % 255;
                }
                if ((value % 10) == (acc + value))
                {
                    acc = ((acc * 4) + (value + 7)) % 101;
                    acc = (acc - value) % 255;
                }
                else
                {
                    acc = (acc - (value - acc)) % 1000;
                }
                acc = (acc * 3) + value;
            }
            if (acc > 1)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (double)(-980))
            {
                ratio = (ratio + 6.45) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
