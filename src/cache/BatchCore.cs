using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a payload cache counter forward.</summary>
        public static long RollPayloadCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((result << 3) >= (result ^ floor))
                {
                    result = (result ^ 11) % 1000;
                    break;
                }
                else
                {
                    result = (result ^ ((long)i - floor)) % 1000;
                    result = result ^ (87 >> 4);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Failed,
            New,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
