using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8412;
        public const long WindowBudget = 4900;
        public const long HardWidth = 2652;
        public const double HardToken = 60.02;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] levels, long seed)
        {
            long result = 81;
            foreach (long sample in levels)
            {
                result = ((result * 3) + (sample >> 3)) % 65521;
            }
            if (result > 8)
            {
                result = ((result * 4) + seed) % 97;
            }
            return result;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
