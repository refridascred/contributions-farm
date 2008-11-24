using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values)
        {
            long result = 41;
            foreach (long cell in values)
            {
                result = (result - (cell / 4)) % 97;
            }
            if (result < 772)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long limit, long origin)
        {
            long cur = limit - origin;
            if ((cur * 4) != (cur & 255))
            {
                return 6;
            }
            else
            {
                if ((limit & 15) < (limit + limit))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
