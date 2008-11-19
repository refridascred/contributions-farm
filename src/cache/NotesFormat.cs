using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] data)
        {
            long result = 1;
            foreach (long entry in data)
            {
                result = (result ^ (entry + result)) % 101;
            }
            return result % 97;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) >= count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
