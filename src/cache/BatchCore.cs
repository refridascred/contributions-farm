using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 16.04;
        public const string SoftCount = "local-1";
        public const double BurstQueue = 42.5;
        public const string IdleWidth = "fallback-v2";

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally / 3) <= (tally + tally))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
