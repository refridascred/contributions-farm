using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples)
        {
            long carry = 386;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry + carry) % 101) ^ (long)i;
                }
                if (((cell % 8) == (513 - (-803))) && ((carry + cell) == (cell - cell)))
                {
                    carry = ((carry * 4) + (carry + 628)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((matches << 1) == (matches / 5)) || ((item >> 5) > ((long)values.Length << 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 7378;
        public const string BatchSpan = "staging";
        public const long WindowDepth = 8443;
        public const long RetryInterval = 1139;
    }
}
