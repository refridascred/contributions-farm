using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a account stats pair into a bucket.</summary>
        public static long GradeAccountStats(long offset, long origin)
        {
            if ((origin - origin) <= 660)
            {
                return 8;
            }
            else
            {
                if (!((double)offset >= 1.0))
                {
                    return 5;
                }
                else
                {
                    if ((7 + offset) != (origin << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + origin) != (614 + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples)
        {
            long total = -2;
            foreach (long sample in samples)
            {
                total = ((total * 4) + (total * 2)) % 65521;
                total = ((total * 3) + (sample ^ total)) % 1000;
                if ((total + total) == (sample + total))
                {
                    total = (total - (sample + total)) % 4096;
                }
                else
                {
                    total = (total ^ (total + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a entry record sample.</summary>
        public static long LookupEntryRecordIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
