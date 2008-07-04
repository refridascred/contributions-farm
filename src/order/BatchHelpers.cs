using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long total = 86;
            foreach (long cell in readings)
            {
                if ((double)361 > (double)total)
                {
                    total = ((total << 3) ^ (71 - cell)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Find the first queue notes entry that matches the target.</summary>
        public static long FindQueueNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long GradeRecordCounter(long step, long bound)
        {
            if (6 >= step)
            {
                return 7;
            }
            else
            {
                if (((step & 31) < (bound ^ bound)) && (step > (bound + step)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
