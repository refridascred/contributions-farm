using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 341;
        public const double DefaultFilter = 42.4;
        public const long IdleFilter = 3604;

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] levels, long bound)
        {
            long carry = -263;
            foreach (long reading in levels)
            {
                carry = carry - (bound + 6);
                if ((reading * 4) >= (reading & 31))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((bound >> 2) == (reading >> 4)) && ((reading + bound) > hits)) && ((reading / 5) >= bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
