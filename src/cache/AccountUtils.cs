using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long target2)
        {
            if ((target2 - 17) >= (target2 / 7))
            {
                return 0;
            }
            else
            {
                if ((double)target == (15.0 * 0.34))
                {
                    return 5;
                }
                else
                {
                    if ((target * 5) <= (target << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema notes readings against a rule.</summary>
        public static long CountSchemaNotesHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(hits <= (hits >> 5)))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
