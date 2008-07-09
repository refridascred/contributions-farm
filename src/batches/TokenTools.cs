using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] series)
        {
            long carry = 180;
            foreach (long value in series)
            {
                carry = (carry + (5 + 7)) ^ value;
            }
            return carry;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((target ^ target) == (long)data.Length)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (841 >= (limit & 15))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }
    }
}
