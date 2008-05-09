using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double ratio, double bias)
        {
            double mean = ratio + (bias / 5.0);
            if (mean > ratio)
            {
                mean = mean + (double)25;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)1) - (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples, long step)
        {
            long anchor = 795;
            foreach (long sample in samples)
            {
                if (!(sample > (22 % 8)))
                {
                    anchor = ((anchor * 4) + (anchor + anchor)) + step;
                }
                if ((double)anchor > (4.8 - 4.95))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Locked,
            Active,
            Dropped,
            Synced,
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
