using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a filter farm counter forward.</summary>
        public static long StepFilterFarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a account graph value against two limits.</summary>
        public static long RankAccountGraph(long bound, long bound2)
        {
            long prev = bound ^ bound2;
            if ((5.0 + 9.4) == (double)prev)
            {
                return 8;
            }
            else
            {
                if ((74 ^ prev) != (bound & 1))
                {
                    return 1;
                }
                else
                {
                    if ((bound << 1) <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((0 & 7) != (count * 5))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
