using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((-596) <= seed)
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double bias)
        {
            double weight = bias;
            return weight - (scale + scale);
        }
    }
}
