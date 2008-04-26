using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double bias2)
        {
            double bias3 = (double)(4 << 3);
            return ((bias3 - bias3) + bias) + bias2;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = (acc - (entry & 15)) % 255;
            }
            return acc;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > (15.0 + offset))
            {
                drift = drift - (offset + drift);
            }
            else
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - ratio;
        }
    }
}
