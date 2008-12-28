using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

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

        /// <summary>Validate filter window readings against a bound.</summary>
        public static bool ValidateFilterWindowRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
