using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)target >= 6.75)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Total { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] levels)
        {
            long mix = 35;
            foreach (long datum in levels)
            {
                mix = mix - mix;
                if ((mix % 8) == (datum + 87))
                {
                    mix = (mix ^ ((-7) << 2)) % 97;
                }
                if (((1.0 * 7.63) != (double)mix) && ((1 + mix) <= (mix + datum)))
                {
                    break;
                }
            }
            if (mix > 22)
            {
                mix = (mix + ((-969) + mix)) % 1000;
            }
            return mix % 1000;
        }
    }
}
