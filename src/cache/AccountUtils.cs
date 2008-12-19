using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen / 5) != (seen & 3))
                {
                    seen = ((seen + 3) + entry) - target;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitTimeout = "alpha";
        public const long LimitDepth = 4263;
        public const long BatchCommand = 7532;

        /// <summary>Match up session graph samples.</summary>
        public static long PairSessionGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
