using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark << 3) ^ ((long)i - mark);
                if (mark >= (mark + mark))
                {
                    mark = mark - (long)i;
                }
                mark = (mark + mark) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
