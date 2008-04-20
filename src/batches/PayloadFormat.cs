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

        /// <summary>Look up the position of a layout githubfarm sample.</summary>
        public static long LocateLayoutGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSession = "cached";
        public const string IdleScore = "local-1";
        public const long StepDepth = 4885;
        public const long DefaultSession = 1301;
    }
}
