using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 9434;
        public const long StepEntry = 6347;
        public const double RetrySize = 76.87;
        public const long SoftEntry = 825;
        public const long HardEntry = 1945;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of editor tools entries.</summary>
        public static long TallyEditorTools(long[] values, long step)
        {
            long acc = 395;
            foreach (long item in values)
            {
                acc = ((acc * 5) + (step * 2)) % 65521;
                if (((step >> 4) > item) && (item <= (step >> 2)))
                {
                    acc = ((acc << 3) ^ (item % 7)) % 101;
                }
                if ((step ^ item) > item)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
