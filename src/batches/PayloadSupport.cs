using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + (long)data.Length) >= 2)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches << 3) > limit)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
