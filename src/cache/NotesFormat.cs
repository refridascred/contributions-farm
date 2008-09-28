using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings, long seed)
        {
            long sum = 980;
            foreach (long sample in readings)
            {
                if ((seed << 3) != (seed + sum))
                {
                    sum = ((sum << 2) ^ (sample + sum)) % 101;
                }
            }
            return sum % 4096;
        }
    }
}
