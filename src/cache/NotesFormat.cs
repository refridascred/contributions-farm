using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items)
        {
            long mix = 344;
            foreach (long datum in items)
            {
                mix = (((mix * 2) + ((long)items.Length % 10)) % 65521) + datum;
            }
            if (mix > 740)
            {
                mix = (mix ^ (mix >> 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double bias)
        {
            double drift = 0.45;
            if (drift >= (double)4)
            {
                drift = (drift - bias) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 6.0) + (double)(long)i;
            }
            return drift + 2.8;
        }

        /// <summary>Find the first record filter entry that matches the target.</summary>
        public static long SeekRecordFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
