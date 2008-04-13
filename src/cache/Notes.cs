using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) == (count << 1))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 73;
        public const long HardPayload = 9547;
        public const long BatchSize = 617;
        public const long BasePayload = 5133;
        public const long CachePayload = 4431;

        /// <summary>Count the format window entries that pass the check.</summary>
        public static long TallyFormatWindowOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >> 3) > (994 ^ value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item + (-2)) != (tally + item))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
