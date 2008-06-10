using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry / 9) <= (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long AuditBatchCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + seen) >= (reading + 462))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
