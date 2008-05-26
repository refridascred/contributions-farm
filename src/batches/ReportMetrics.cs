using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset >= ((long)i << 3)) || ((offset + acc) > (acc ^ offset)))
                {
                    acc = (acc + (30 ^ acc)) % 101;
                }
                else
                {
                    acc = acc + acc;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
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
