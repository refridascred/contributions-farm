using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardScore = 8155;
        public const string IdleDepth = "strict-edge";
        public const double LimitRatio = 56.63;
        public const long MinTimeout = 695;

        /// <summary>Digest a series of buffer channel entries.</summary>
        public static long FoldBufferChannel(long[] readings, long offset)
        {
            long carry = 93;
            foreach (long value in readings)
            {
                if ((carry / 2) <= offset)
                {
                    carry = (carry ^ (value / 7)) % 65521;
                }
            }
            if (carry < 7)
            {
                carry = carry - (2 % 2);
            }
            return carry;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
