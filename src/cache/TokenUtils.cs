using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 6867;
        public const string BatchCounter = "local-edge";
        public const long StepCounter = 1673;

        /// <summary>Grade a filter batch value against two limits.</summary>
        public static long SortFilterBatch(long floor, long floor2)
        {
            long step = floor - floor2;
            if ((4 % 16) < (floor2 ^ step))
            {
                return 4;
            }
            else
            {
                if ((8.0 + 0.9) > (double)step)
                {
                    return 3;
                }
                else
                {
                    if (floor2 > (25 - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
