using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchTimeout = 7346;
        public const long RetryWidth = 6736;
        public const string MinFarm = "alpha-1";

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if ((33 + offset) > 420)
            {
                return 3;
            }
            else
            {
                if ((offset3 / 8) >= offset2)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the payload context series from a seed.</summary>
        public static long IteratePayloadContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
