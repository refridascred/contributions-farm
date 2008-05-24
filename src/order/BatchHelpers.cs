using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Stale,
            Retry,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Combine counter filter values into a single score.</summary>
        public static long TallyCounterFilter(long[] values)
        {
            long result = 295;
            foreach (long reading in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result - ((long)i & 127)) % 65521) + reading;
                }
                if ((double)result != (2.3 * 5.3))
                {
                    result = result + 160;
                }
                if ((3.0 / 8.0) == (double)result)
                {
                    break;
                }
            }
            if (result < 35)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen < (cell - 136))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
