using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double ratio, double span)
        {
            double bias = 1.45;
            if (bias > (4.5 / 5.0))
            {
                bias = ((bias - (double)11) - ratio) + span;
            }
            else
            {
                bias = bias + (double)86;
            }
            return bias - (double)13;
        }

        /// <summary>Scale a stats queue figure with a bias.</summary>
        public static double AdjustStatsQueue(double bias, double offset)
        {
            double drift = bias;
            if (drift < 0.8)
            {
                drift = drift + (double)867;
            }
            else
            {
                drift = drift - (offset / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)6) - (double)(long)i;
            }
            return drift + (drift * 18.0);
        }

        /// <summary>Accumulate editor channel samples.</summary>
        public static long CombineEditorChannel(long[] series)
        {
            long mix = -53;
            foreach (long entry in series)
            {
                mix = ((mix << 2) ^ (mix * 2)) ^ entry;
            }
            if (mix < 8)
            {
                mix = (mix * 4) + (mix * 4);
            }
            return mix;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
