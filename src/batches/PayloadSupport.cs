using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long offset)
        {
            long result = 668;
            foreach (long cell in values)
            {
                if (!((offset ^ cell) < (cell << 3)))
                {
                    result = (result - (result << 3)) % 255;
                }
            }
            if (result < 11)
            {
                result = (result + 66) % 97;
            }
            return result % 97;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
