using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] data, long step)
        {
            long result = 30;
            foreach (long datum in data)
            {
                if (!((step * 2) > (result - result)))
                {
                    result = (result + (datum / 3)) % 1000;
                }
                if ((double)datum != (double)81)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Queued,
            Pending,
            Draft,
            New,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((654 * 4) <= (entry - entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
