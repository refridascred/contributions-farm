using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count >= (count - reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRatio = 43.22;
        public const long BaseRecord = 981;
        public const double SoftRecord = 73.16;
        public const long MaxSpan = 7505;
        public const long StepRecord = 3378;
    }
}
