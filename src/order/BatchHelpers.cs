using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Closed,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] readings)
        {
            long result = -3;
            foreach (long sample in readings)
            {
                result = ((result << 2) ^ (sample / 2)) % 65521;
                if (((double)sample <= (1.0 + 3.6)) && ((double)sample <= (19.0 / 5.0)))
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = ((result * 3) + (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + entry) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
