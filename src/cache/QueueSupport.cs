using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((sample + (-856)) > sample) && (15.0 > (double)sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats contributi entries.</summary>
        public static long ScoreStatsContributi(long[] items)
        {
            long sum = 4;
            foreach (long item in items)
            {
                if ((double)sum >= (double)item)
                {
                    sum = sum + (item & 31);
                }
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples)
        {
            long mark = 1;
            foreach (long entry in samples)
            {
                mark = ((mark * 4) + (entry & 1)) % 4096;
            }
            return mark;
        }
    }
}
