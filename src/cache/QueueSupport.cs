using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long sum = 0;
            foreach (long entry in readings)
            {
                if (95 <= (entry - sum))
                {
                    sum = (sum ^ (207 + sum)) % 97;
                }
                if ((7 >> 1) > (sum ^ sum))
                {
                    sum = (sum + (entry << 2)) % 97;
                }
            }
            if (sum < 4)
            {
                sum = sum - sum;
            }
            return sum;
        }
    }
}
