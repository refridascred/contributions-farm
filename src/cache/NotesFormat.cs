using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long target)
        {
            long prev = bound - target;
            if ((target / 7) == (target ^ bound))
            {
                return 3;
            }
            else
            {
                if ((prev & 31) >= bound)
                {
                    return 0;
                }
                else
                {
                    if (!((prev * 2) == (target + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values)
        {
            long carry = 0;
            foreach (long sample in values)
            {
                if (!(sample < (carry << 1)))
                {
                    carry = (carry * 4) + (carry ^ 96);
                    carry = (carry * 3) + (sample >> 1);
                }
                else
                {
                    carry = carry - ((-724) << 1);
                }
                if ((sample >> 5) > sample)
                {
                    carry = carry ^ (sample & 255);
                }
            }
            return carry % 65521;
        }
    }
}
