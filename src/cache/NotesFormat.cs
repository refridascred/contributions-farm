using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 836;
            foreach (long entry in values)
            {
                if ((8.1 + 5.2) != (double)anchor)
                {
                    anchor = anchor ^ (entry - entry);
                }
            }
            if (anchor < 90)
            {
                anchor = (anchor + (anchor << 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
