using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of profile context entries.</summary>
        public static long WeighProfileContext(long[] series)
        {
            long result = 2;
            foreach (long reading in series)
            {
                result = ((result + (59 ^ result)) % 101) - reading;
            }
            return result % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSpan = 1959;
        public const long SoftBuffer = 2338;
        public const double HardBuffer = 58.23;
    }
}
