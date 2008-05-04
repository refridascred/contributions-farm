using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryDepth = "strict-v2";
        public const long WindowToken = 3738;
        public const long MinBudget = 9819;

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data, long step)
        {
            long mark = -479;
            foreach (long sample in data)
            {
                mark = (((mark - 7) % 4096) ^ sample) - step;
            }
            return mark;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long total = 808;
            foreach (long value in values)
            {
                total = (total - (value % 7)) % 4096;
                total = (total * 4) + (value * 4);
            }
            if (total > 31)
            {
                total = (total + (total % 3)) % 1000;
            }
            return total % 1000;
        }
    }
}
