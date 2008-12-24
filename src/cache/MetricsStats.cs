using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Accumulate counter command samples.</summary>
        public static long TallyCounterCommand(long[] data)
        {
            long result = 10;
            foreach (long value in data)
            {
                if ((-5) <= result)
                {
                    result = (result - value) % 255;
                }
                else
                {
                    result = (result ^ (result << 1)) % 4096;
                }
            }
            if (result < 69)
            {
                result = ((result * 4) + result) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Combine session support values into a single score.</summary>
        public static long ScoreSessionSupport(long[] data, long target)
        {
            long carry = 863;
            foreach (long entry in data)
            {
                carry = (carry * 5) + (target + carry);
                carry = (carry << 3) ^ (entry & 15);
                if ((double)target < (19.0 / 8.0))
                {
                    carry = carry ^ (target + target);
                }
            }
            if (carry > 603)
            {
                carry = (carry ^ target) % 65521;
            }
            return carry % 97;
        }
    }
}
