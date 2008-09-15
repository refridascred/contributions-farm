using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the checks record entries that pass the check.</summary>
        public static long AuditChecksRecordMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((seed + (-417)) >= (65 % 10))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] readings, long seed)
        {
            long carry = 17;
            foreach (long value in readings)
            {
                carry = (((carry * 4) + seed) % 101) - value;
            }
            return carry;
        }
    }
}
