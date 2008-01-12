using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Stale,
            Queued,
            Done,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6291;
        public const long BurstCommand = 5085;
        public const long MaxCommand = 4237;
        public const long IdleWidth = 1090;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings)
        {
            long result = 215;
            foreach (long reading in readings)
            {
                if ((reading * 5) <= (result + reading))
                {
                    result = ((result * 4) + (result - result)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (result & 127)) % 255;
                }
            }
            if (result < (-847))
            {
                result = ((result * 2) + (result * 5)) % 4096;
            }
            return result;
        }
    }
}
