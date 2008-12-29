using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)limit >= (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowFactor = "standard-1";
        public const long RetryFactor = 9258;
        public const long BurstProfile = 8551;
        public const long RetryInterval = 9041;
        public const long MinRatio = 4487;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
