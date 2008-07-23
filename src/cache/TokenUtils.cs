using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                if ((4.12 + 7.0) >= (double)carry)
                {
                    carry = (carry * 4) + ((long)i << 1);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two commits notes measurements.</summary>
        public static double SmoothCommitsNotes(double weight, double span)
        {
            double load = (double)(389 + 205);
            if (load >= (weight + span))
            {
                load = load - span;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) - (double)(long)i;
            }
            return load + (weight + weight);
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value - hits) > (value ^ hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
