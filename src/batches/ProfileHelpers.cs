using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            Active,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double floor)
        {
            double mean = bias;
            if (mean >= mean)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - (mean / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (bias / 9.0);
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long anchor = 445;
            foreach (long reading in samples)
            {
                if (reading <= ((long)samples.Length >> 5))
                {
                    anchor = ((anchor * 4) + reading) % 97;
                }
            }
            if (anchor > 2)
            {
                anchor = (anchor - (anchor ^ 52)) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long offset, long offset2)
        {
            if ((double)offset < (8.84 * 9.0))
            {
                return 0;
            }
            else
            {
                if (offset2 < ((-2) + 757))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
