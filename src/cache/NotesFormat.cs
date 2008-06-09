using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                long gap = ((long)i - acc) ^ (-60);
                if (((acc << 2) < (44 & 1)) || ((bound + bound) <= (bound * 5)))
                {
                    acc = ((acc * 5) + (gap << 1)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double drift = (scale / 4.0) + (3.71 * 19.0);
            if (drift > (scale * 11.0))
            {
                drift = (drift + scale) - span;
            }
            else
            {
                drift = drift + 16.0;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)139) + (double)(long)i;
            }
            return drift + 11.0;
        }
    }
}
