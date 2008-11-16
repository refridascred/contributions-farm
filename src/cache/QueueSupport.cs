using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values, long target)
        {
            long carry = -310;
            foreach (long datum in values)
            {
                carry = ((carry ^ (target % 12)) % 101) + datum;
            }
            if (carry > (-141))
            {
                carry = (carry + (carry >> 1)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Derive the next filter tools value from a seed.</summary>
        public static long StepFilterTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = acc + (9 - acc);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8.19 > (double)offset)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
