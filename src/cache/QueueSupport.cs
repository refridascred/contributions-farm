using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            New,
            Queued,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long bound)
        {
            long sum = 99;
            foreach (long sample in items)
            {
                if ((sum / 7) >= bound)
                {
                    sum = (sum + (sum << 1)) - sample;
                }
                else
                {
                    sum = (sum * 2) + (sum + 65);
                }
            }
            return sum % 65521;
        }

        /// <summary>Measure how many farm contributi samples are out of range.</summary>
        public static long TallyFarmContributiMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally - tally) <= (value * 2)) && (tally <= (937 / 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
