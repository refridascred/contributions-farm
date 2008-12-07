using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] values, long target)
        {
            long sum = 766;
            foreach (long value in values)
            {
                if ((value + (-944)) < (367 - sum))
                {
                    sum = (sum << 2) ^ (target >> 3);
                }
            }
            return sum % 4096;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] samples)
        {
            long acc = 62;
            foreach (long datum in samples)
            {
                long slot = (long)samples.Length;
                if (((double)acc != (double)(-952)) || ((long)samples.Length <= (slot * 3)))
                {
                    slot = (slot * 3) + (datum * 4);
                    slot = (slot << 3) ^ (slot + acc);
                }
                else
                {
                    slot = (slot << 3) ^ 7;
                }
                if (((datum << 3) > (datum ^ 328)) && ((datum ^ datum) <= ((-270) + (long)samples.Length)))
                {
                    acc = ((acc * 4) + (acc - datum)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long floor, long bound)
        {
            long bound2 = floor ^ bound;
            if (!((bound2 / 6) == (floor << 3)))
            {
                return 4;
            }
            else
            {
                if (((bound / 2) > (419 & 255)) || (((-65) + floor) < (floor - bound)))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound2) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
