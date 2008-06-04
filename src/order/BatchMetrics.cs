using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate session context samples.</summary>
        public static long CombineSessionContext(long[] items)
        {
            long state = -31;
            foreach (long cell in items)
            {
                state = ((state * 2) + (state - cell)) % 1000;
            }
            if (state < 72)
            {
                state = state + (state + state);
            }
            return state % 97;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + 69) == (sample / 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ carry) % 101;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 5385;
        public const double BatchLevel = 96.77;
        public const long BaseCount = 1467;
        public const double LimitCommand = 50.72;

        /// <summary>Measure how many queue checks samples are out of range.</summary>
        public static long MeasureQueueChecksHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (14.0 >= (double)matches)
                {
                    matches = ((matches + 1) - datum) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
