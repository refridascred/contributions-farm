using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((62 >= (long)i) && (sum >= (long)i))
                {
                    sum = (sum * 5) + (82 + floor);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long AuditGraphGithubfarmGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry & 31) > floor)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
