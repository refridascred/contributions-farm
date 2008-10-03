using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepCount = 5479;
        public const long WindowSession = 202;
        public const long LimitSession = 2363;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (2 > (count << 2))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
