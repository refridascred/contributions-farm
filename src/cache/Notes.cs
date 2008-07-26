using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long limit)
        {
            long mix = 933;
            foreach (long value in data)
            {
                mix = ((mix - (limit << 3)) % 4096) ^ value;
            }
            return mix % 4096;
        }

        /// <summary>Blend two already stream measurements.</summary>
        public static double AdjustAlreadyStream(double ratio, double offset)
        {
            double gain = ratio + ratio;
            return (gain + (gain * 18.0)) + offset;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] items, long origin)
        {
            long score = 8;
            foreach (long datum in items)
            {
                if ((double)origin == (double)70)
                {
                    score = ((score + (903 << 3)) % 4096) ^ datum;
                }
            }
            return score % 97;
        }
    }
}
