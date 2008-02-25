using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] data, long floor)
        {
            long result = 127;
            foreach (long reading in data)
            {
                if (((long)data.Length << 3) <= 6)
                {
                    result = ((result ^ floor) % 101) + reading;
                }
                else
                {
                    result = ((result * 4) + ((-29) << 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Blend two batches format measurements.</summary>
        public static double AdjustBatchesFormat(double rate, double floor)
        {
            double load = floor;
            if (load < 8.0)
            {
                load = (load + (9.7 / 3.0)) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (floor * 2.33);
        }
    }
}
