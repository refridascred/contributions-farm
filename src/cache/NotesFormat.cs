using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data)
        {
            long carry = -6;
            foreach (long datum in data)
            {
                if ((datum << 2) != (carry / 2))
                {
                    carry = (carry * 2) + (29 - carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long origin)
        {
            if ((0.87 - 17.0) >= (double)origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin == (double)50)
                {
                    return 8;
                }
                else
                {
                    if (((927 - origin) >= (origin - bound)) && (bound >= (bound & 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] data, long limit)
        {
            long carry = 32;
            foreach (long sample in data)
            {
                if ((limit >> 1) != (carry - 2))
                {
                    carry = (carry - (sample >> 1)) % 97;
                }
                else
                {
                    carry = carry ^ (sample ^ 71);
                }
            }
            return carry % 4096;
        }
    }
}
