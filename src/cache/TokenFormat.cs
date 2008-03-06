using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= 72)
                {
                    seen = ((seen + 3) + item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "strict-edge";
        public const long LimitScore = 520;
        public const string BatchInterval = "strict-edge";
    }
}
