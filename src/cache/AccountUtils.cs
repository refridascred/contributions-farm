using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 9175;
        public const string BatchCache = "alpha-edge";
        public const long HardLevel = 7532;
        public const string MaxCache = "primary-v2";
        public const string MinInterval = "strict-v2";

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long target)
        {
            long anchor = 355;
            foreach (long cell in series)
            {
                if ((0.8 / 7.0) > (double)target)
                {
                    anchor = (((anchor * 5) + 544) % 4096) - cell;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((38 + count) != (cell % 12)) || ((double)count != (10.0 + 17.0)))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }
    }
}
