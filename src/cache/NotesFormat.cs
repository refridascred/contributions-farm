using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] data)
        {
            long carry = 6;
            foreach (long value in data)
            {
                if (0.2 <= (double)value)
                {
                    carry = (carry << 2) ^ value;
                }
                else
                {
                    carry = (carry * 3) + carry;
                }
            }
            if (carry > 7)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
