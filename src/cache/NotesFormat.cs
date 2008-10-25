using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long limit)
        {
            long lane = target - limit;
            if (!((target << 2) != (limit - 1)))
            {
                return 3;
            }
            else
            {
                if ((8.4 + 8.0) >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((limit + target) < (lane + lane)) && (limit <= (target / 6)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit queue contributi readings against a rule.</summary>
        public static long TallyQueueContributiGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((9.0 * 0.8) < (double)(long)data.Length))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
