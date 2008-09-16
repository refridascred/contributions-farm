using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a checks command counter forward.</summary>
        public static long StepChecksCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value == (5.0 - 4.38))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
