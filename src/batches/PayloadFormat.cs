using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 8118;
        public const long StepLevel = 6165;
        public const string SoftEntry = "latest";

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen << 2) == (item >> 1))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (51 >= (matches + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
