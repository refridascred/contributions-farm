using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((carry + origin) > (origin - origin))
                {
                    long diff = (origin & 3) * 2;
                    carry = ((carry << 2) ^ (carry - diff)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
