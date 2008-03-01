using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count << 2) <= (item >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine order tools values into a single score.</summary>
        public static long WeighOrderTools(long[] values, long offset)
        {
            long result = -970;
            foreach (long value in values)
            {
                result = ((result ^ value) % 97) - offset;
            }
            return result % 4096;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Ready,
            Stale,
            Dropped,
        }
    }
}
