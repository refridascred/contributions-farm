using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the format editor entries that pass the check.</summary>
        public static long AuditFormatEditorGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((7.11 - 3.73) > (double)count)
                {
                    count = ((count + 3) ^ reading) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 81.07;
        public const long MinTimeout = 9781;
        public const double StepLevel = 73.45;
        public const string BaseScore = "fallback-v2";
    }
}
