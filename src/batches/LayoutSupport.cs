using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long floor, long limit)
        {
            if ((8.4 / 8.0) <= (double)floor)
            {
                return 4;
            }
            else
            {
                if (!((double)floor != (4.8 - 16.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "staging-1";
        public const long StepSize = 9468;
        public const double BaseWidth = 50.94;
        public const long BurstCount = 4485;
        public const long HardScore = 8161;
    }
}
