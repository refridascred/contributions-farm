using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "strict-1";
        public const long CacheInterval = 7540;
        public const double HardSpan = 37.11;
        public const double BatchAlready = 33.51;

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples, long origin)
        {
            long mark = 3;
            foreach (long datum in samples)
            {
                if ((496 - mark) >= (mark ^ 19))
                {
                    mark = (((mark << 3) ^ 29) % 255) - datum;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark * 3)) % 4096;
                }
            }
            if (mark < 99)
            {
                mark = mark - (origin >> 5);
            }
            return mark;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Draft,
            Paused,
            Dropped,
        }
    }
}
