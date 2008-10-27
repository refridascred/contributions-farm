using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((5.1 / 4.0) > (double)sample)
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftTimeout = "strict-edge";
        public const double DefaultCommand = 76.19;
        public const long RetryCount = 4003;
        public const double MinCommand = 52.7;
        public const long WindowTimeout = 3405;
    }
}
