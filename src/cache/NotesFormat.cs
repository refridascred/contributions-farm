using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next batches already value.</summary>
        public static double ProjectBatchesAlready(double ratio, double offset)
        {
            double scale = (0.91 * 4.49) - (ratio - offset);
            if (scale < offset)
            {
                scale = scale + (scale / 7.0);
            }
            else
            {
                scale = scale + (ratio * 9.51);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale - 0.3)) - (double)(long)i;
            }
            return scale + (ratio * 3.49);
        }

        /// <summary>Look up the position of a context notes sample.</summary>
        public static long LocateContextNotesIndex(long[] samples, long step)
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
    }
}
