using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Active,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardBudget = 1606;
        public const long WindowBudget = 8686;
        public const double BurstAlready = 1.8;
        public const string LimitAlready = "cached-edge";
    }
}
