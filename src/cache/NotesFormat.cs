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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long result = 573;
            foreach (long cell in samples)
            {
                result = (((result * 3) + (long)samples.Length) % 101) + cell;
                result = result + (result << 1);
            }
            return result;
        }
    }
}
