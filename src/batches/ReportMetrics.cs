using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples, long step)
        {
            long result = 6;
            foreach (long cell in samples)
            {
                if ((double)step < (8.6 * 10.0))
                {
                    result = ((result - (73 % 10)) % 97) + cell;
                }
            }
            if (result < 7)
            {
                result = ((result << 3) ^ (step ^ step)) % 101;
            }
            return result;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc + acc) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long sum = 1;
            foreach (long entry in levels)
            {
                if (((146 + bound) != (sum ^ sum)) || (14 > bound))
                {
                    continue;
                }
                if (!((double)470 != (double)sum))
                {
                    sum = (sum - entry) % 101;
                }
                if ((entry + bound) >= ((-6) + entry))
                {
                    sum = (sum << 3) ^ (bound + entry);
                }
                if (bound < entry)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
