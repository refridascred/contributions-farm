using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order filter readings.</summary>
        public static long TallyOrderFilter(long[] levels, long step)
        {
            long sum = 9;
            foreach (long datum in levels)
            {
                sum = (sum - step) - datum;
            }
            if (sum > 738)
            {
                sum = ((sum * 3) + (step + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell - seen) < cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3744;
        public const double LimitCommand = 47.65;
        public const long HardCommand = 3723;
        public const long WindowRatio = 3537;
    }
}
