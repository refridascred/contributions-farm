using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double rate = floor;
            if (rate <= floor)
            {
                rate = rate - (double)26;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long offset)
        {
            if (offset > (offset & 3))
            {
                return 0;
            }
            else
            {
                if (offset <= (offset % 2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long sum = 3;
            foreach (long datum in readings)
            {
                sum = ((sum * 3) + 2) + datum;
            }
            return sum % 4096;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Pending,
            New,
        }
    }
}
