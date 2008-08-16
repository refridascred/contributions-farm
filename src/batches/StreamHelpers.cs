using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (9.66 >= (double)matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
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
