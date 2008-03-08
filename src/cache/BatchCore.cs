using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double span)
        {
            double ratio = span * 4.99;
            if (ratio > rate)
            {
                ratio = ratio + (double)0;
            }
            else
            {
                ratio = ratio + (span * 0.6);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - ((long)i ^ floor)) % 1000;
                acc = acc + acc;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
