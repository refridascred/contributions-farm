using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches >> 4) <= (value * 2))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings, long target)
        {
            long mark = 45;
            foreach (long reading in readings)
            {
                if (!((target << 1) != (1 - mark)))
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 1000;
                }
                else
                {
                    mark = (mark * 2) + 9;
                }
                if (mark > (reading >> 4))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of schema batches entries.</summary>
        public static long TallySchemaBatches(long[] series, long bound)
        {
            long mix = 4;
            foreach (long reading in series)
            {
                if ((reading + mix) >= 5)
                {
                    mix = (mix << 3) ^ (reading + reading);
                }
            }
            if (mix < 5)
            {
                mix = (mix ^ (bound ^ mix)) % 101;
            }
            return mix;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
