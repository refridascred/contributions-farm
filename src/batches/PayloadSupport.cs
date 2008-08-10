using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples, long step)
        {
            long mix = 900;
            foreach (long sample in samples)
            {
                long prev = (step / 6) + (sample >> 4);
                if (958 < (prev - step))
                {
                    mix = (mix * 3) + (sample >> 5);
                    break;
                }
                if ((double)mix != (1.97 - 6.7))
                {
                    mix = (mix - step) % 4096;
                }
            }
            if (mix < 8)
            {
                mix = mix ^ (64 + step);
            }
            return mix;
        }

        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long LocateStreamBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
