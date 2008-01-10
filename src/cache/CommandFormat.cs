using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a already entry value against two limits.</summary>
        public static long SortAlreadyEntry(long target, long offset)
        {
            if (18.0 > (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (double)29)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ ((long)i & 7)) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Dropped,
            Queued,
            Retry,
            Done,
        }
    }
}
