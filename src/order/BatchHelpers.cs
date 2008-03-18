using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading >= (reading + count))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((mark % 7) <= (635 ^ 2)) && (((long)i - limit) >= (mark << 1)))
                {
                    mark = ((mark << 3) ^ (limit & 127)) % 97;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit entry contributi readings against a rule.</summary>
        public static long TallyEntryContributiGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally % 2) <= tally)
                {
                    tally = ((tally + 2) - reading) - step;
                }
            }
            return tally;
        }
    }
}
