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

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] series, long bound)
        {
            long anchor = 2;
            foreach (long value in series)
            {
                if (((value << 3) > ((long)series.Length + 23)) || ((double)value >= (1.8 / 7.0)))
                {
                    anchor = anchor + (anchor ^ bound);
                }
            }
            return anchor;
        }
    }
}
