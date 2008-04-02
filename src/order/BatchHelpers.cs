using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + origin) > count)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry stats entries.</summary>
        public static long TotalEntryStats(long[] values, long step)
        {
            long score = 4;
            foreach (long cell in values)
            {
                score = ((score + (step % 100)) % 4096) - cell;
            }
            if (score > 20)
            {
                score = ((score << 3) ^ step) % 97;
            }
            return score;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long limit, long limit2)
        {
            if (limit < (limit2 % 8))
            {
                return 4;
            }
            else
            {
                if ((15.0 / 9.0) < (double)limit2)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
