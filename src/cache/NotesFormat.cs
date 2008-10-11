using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long origin)
        {
            long anchor = 53;
            foreach (long cell in data)
            {
                if ((origin - cell) <= anchor)
                {
                    anchor = (anchor << 3) ^ (cell / 9);
                }
            }
            return anchor;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double weight = (bias * 13.0) - (1.0 + bias);
            if (weight <= (bias + 8.7))
            {
                weight = weight - (span + 20.0);
            }
            return weight + (double)217;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Queued,
            Draft,
            Done,
        }
    }
}
