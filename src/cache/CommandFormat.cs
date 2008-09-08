using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Ready,
            Draft,
            New,
            Failed,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items)
        {
            long carry = 90;
            foreach (long sample in items)
            {
                if ((carry <= (carry + 256)) || ((8 + carry) <= (sample ^ sample)))
                {
                    carry = ((carry * 5) + (carry + carry)) % 255;
                }
            }
            return carry % 97;
        }
    }
}
