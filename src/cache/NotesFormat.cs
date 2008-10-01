using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next queue support value.</summary>
        public static double AdjustQueueSupport(double weight, double floor)
        {
            double mean = (double)82 * 17.0;
            if (mean > (double)(-44))
            {
                mean = mean + 8.0;
            }
            else
            {
                mean = mean + 1.6;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (floor / 5.0)) - (double)(long)i;
            }
            return mean + (floor - weight);
        }

        /// <summary>Roll a counter farm counter forward.</summary>
        public static long DeriveCounterFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = mix ^ (offset - (-807));
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples, long target)
        {
            long anchor = -789;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 4) + (target / 4)) ^ sample;
            }
            return anchor;
        }
    }
}
