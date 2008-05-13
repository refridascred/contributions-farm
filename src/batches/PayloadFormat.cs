using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheBudget = 6745;
        public const string DefaultWidth = "latest-edge";
        public const long MaxStream = 5405;
        public const long MinStream = 1411;
        public const long StepStream = 7139;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] values, long offset)
        {
            long acc = -536;
            foreach (long item in values)
            {
                acc = (((acc << 2) ^ (item - 43)) % 1000) - offset;
            }
            return acc;
        }
    }
}
