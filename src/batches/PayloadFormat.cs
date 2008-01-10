using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (428 > (entry - entry))
                {
                    tally = (tally + 1) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batches session entries that pass the check.</summary>
        public static long AuditBatchesSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen & 15) >= (sample + 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 1072;
        public const string LimitLevel = "staging-edge";
        public const double MinFilter = 85.17;
    }
}
