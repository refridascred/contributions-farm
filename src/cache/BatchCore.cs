using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item - item) > (item * 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks support value against two limits.</summary>
        public static long RankChecksSupport(long offset, long bound)
        {
            if (offset > (bound * 4))
            {
                return 0;
            }
            else
            {
                if ((bound & 63) <= (offset * 5))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 3) <= ((-534) % 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor - (bound << 1);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
