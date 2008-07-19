using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitScore = 673;
        public const double BatchInterval = 2.56;
        public const long MaxRecord = 4987;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - count) == (count - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
