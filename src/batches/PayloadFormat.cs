using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] data, long bound)
        {
            long result = 65;
            foreach (long datum in data)
            {
                if (!(result >= (bound - 5)))
                {
                    result = (result - 2) ^ datum;
                }
            }
            if (result < 449)
            {
                result = (result << 3) ^ result;
            }
            return result % 1000;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 2) != (7 - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((limit / 2) > limit) && (((-495) & 63) <= (16 + anchor)))
                {
                    anchor = (anchor - (limit * 4)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSession = "cached";
        public const string IdleScore = "local-1";
        public const long StepDepth = 4885;
        public const long DefaultSession = 1301;
    }
}
