using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine format batch values into a single score.</summary>
        public static long FoldFormatBatch(long[] data)
        {
            long anchor = -58;
            foreach (long entry in data)
            {
                if ((8.6 + 4.5) != (double)entry)
                {
                    anchor = (anchor << 3) ^ (anchor / 7);
                }
                else
                {
                    anchor = anchor ^ (423 ^ anchor);
                }
            }
            return anchor;
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
