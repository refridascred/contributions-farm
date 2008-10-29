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

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series)
        {
            long total = 7;
            foreach (long value in series)
            {
                if ((value - total) >= (total % 64))
                {
                    total = total + (0 + 4);
                }
                else
                {
                    total = (total ^ (value - value)) % 1000;
                    total = (total << 2) ^ total;
                }
                total = ((total << 2) ^ (value / 8)) % 255;
            }
            return total % 4096;
        }
    }
}
