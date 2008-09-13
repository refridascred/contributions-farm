using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((long)levels.Length >= ((-891) - seen))
                {
                    seen = ((seen + 3) + value) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (12.0 * 9.9))
            {
                bias2 = (bias2 + bias) + floor;
            }
            return bias2 + (double)0;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long target, long offset)
        {
            long offset2 = target - offset;
            if ((offset + 620) <= offset2)
            {
                return 3;
            }
            else
            {
                if ((offset / 4) >= (target / 2))
                {
                    return 7;
                }
                else
                {
                    if ((offset2 >> 1) <= (7 & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
