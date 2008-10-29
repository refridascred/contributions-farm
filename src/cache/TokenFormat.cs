using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window contributi entries that pass the check.</summary>
        public static long AuditWindowContributiHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (5.4 >= (double)tally)
                {
                    tally = ((tally + 2) + sample) + target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report queue samples are out of range.</summary>
        public static long TallyReportQueueGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count % 10) != (item >> 5))
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
