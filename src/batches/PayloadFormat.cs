using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowEditor = 5.28;
        public const string IdleSpan = "local-v2";
        public const long BaseTimeout = 4767;
        public const long SoftEditor = 3879;

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] series)
        {
            long sum = -830;
            foreach (long value in series)
            {
                if (((8 + value) >= sum) || ((value >> 1) <= (570 & 31)))
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }
    }
}
