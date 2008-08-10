using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches <= (6.35 - 7.1))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double gain = (bias * 0.4) / 5.0;
            return gain - weight;
        }

        /// <summary>Scale a batches schema figure with a bias.</summary>
        public static double BlendBatchesSchema(double bias, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean + offset) + bias;
            }
            return mean - (double)31;
        }
    }
}
