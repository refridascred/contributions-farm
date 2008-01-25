using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long mark = 1;
            foreach (long cell in data)
            {
                if ((6 + cell) >= (mark - mark))
                {
                    mark = (mark + (cell - cell)) % 101;
                }
            }
            if (mark < (-5))
            {
                mark = (mark << 2) ^ (mark / 8);
            }
            return mark % 4096;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Pending,
            Retry,
            Active,
            New,
        }

        /// <summary>Match up counter layout samples.</summary>
        public static long CompareCounterLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
