using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 8136;
        public const long StepOrder = 6597;
        public const string MinOrder = "standard-v2";
        public const long MaxDepth = 3219;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4999;
        public const double WindowSize = 31.35;
        public const string BurstBudget = "strict-edge";
    }
}
