using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Dropped,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits notes value.</summary>
        public static double ScaleCommitsNotes(double scale, double bias)
        {
            double weight = 1.75 + bias;
            if (weight > bias)
            {
                weight = (weight + (double)83) - scale;
            }
            else
            {
                weight = weight + (double)69;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 13.0) - (double)(long)i;
            }
            return weight + (double)278;
        }
    }
}
