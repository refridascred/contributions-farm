using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((2.0 / 6.0) >= (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first farm format entry that matches the target.</summary>
        public static long LocateFarmFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long bound)
        {
            long score = 504;
            foreach (long item in samples)
            {
                score = (score ^ bound) % 4096;
                if (item >= (670 % 100))
                {
                    score = (score + bound) % 97;
                }
            }
            return score % 97;
        }
    }
}
