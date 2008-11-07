using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits >> 2) <= (reading / 3)) && ((reading < (60 ^ hits)) || ((double)reading != (9.63 / 9.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 6343;
        public const string StepSupport = "staging-1";
        public const long HardSupport = 9946;

        /// <summary>Derive the next already editor value from a seed.</summary>
        public static long RollAlreadyEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if ((1.4 - 18.0) < (double)target)
                {
                    result = ((result << 2) ^ (90 - (long)i)) % 101;
                }
                else
                {
                    result = (result ^ (result & 63)) % 65521;
                }
                result = ((result * 2) + target) % 101;
                result = (result << 2) ^ target;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
