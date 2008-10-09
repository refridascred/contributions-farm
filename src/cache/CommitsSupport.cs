using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] data, long step)
        {
            long result = 843;
            foreach (long datum in data)
            {
                result = (result << 2) ^ (result / 7);
                result = result + (datum % 10);
            }
            if (result < 2)
            {
                result = ((result * 2) + (step - 20)) % 97;
            }
            return result % 97;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            New,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Pending,
            Draft,
            New,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                if ((limit ^ sample) == (sample % 5))
                {
                    sum = sum - sum;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches >= (datum >> 2)) || ((double)datum > (9.97 - 2.4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Draft,
            Pending,
            Done,
        }
    }
}
