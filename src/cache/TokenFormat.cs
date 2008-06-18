using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank format support input into a small class.</summary>
        public static long GradeFormatSupport(long step, long floor)
        {
            long offset = step - floor;
            if ((floor / 7) < step)
            {
                return 7;
            }
            else
            {
                if ((floor - offset) > (floor % 7))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
