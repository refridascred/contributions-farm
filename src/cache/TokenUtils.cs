using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] data, long floor)
        {
            long mix = 9;
            foreach (long value in data)
            {
                if (!((value - mix) >= (long)data.Length))
                {
                    mix = (mix + 3) - floor;
                }
                mix = (mix ^ 6) % 101;
                mix = mix + (value & 3);
            }
            return mix % 4096;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
