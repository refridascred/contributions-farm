using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double gain, double span)
        {
            double gain2 = gain / 3.0;
            if (gain2 >= (double)55)
            {
                gain2 = gain2 + span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - (7.1 * 9.3)) + (double)(long)i;
            }
            return gain2 + span;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long state = 18;
            foreach (long reading in samples)
            {
                if ((reading * 3) >= reading)
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Pending,
            Closed,
            Dropped,
            Queued,
        }
    }
}
