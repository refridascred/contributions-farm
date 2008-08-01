using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseCount = 1239;
        public const double DefaultStream = 67.79;
        public const long MaxStream = 4711;

        /// <summary>Count the batch order entries that pass the check.</summary>
        public static long TallyBatchOrderOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally - origin) > value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
