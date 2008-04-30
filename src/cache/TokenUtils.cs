using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two window channel measurements.</summary>
        public static double SmoothWindowChannel(double ratio, double span)
        {
            double rate = ratio + ratio;
            if (rate > ratio)
            {
                rate = rate - span;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)(-58)) + (double)(long)i;
            }
            return rate + (double)644;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell >= (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Failed,
            Draft,
            Stale,
        }
    }
}
