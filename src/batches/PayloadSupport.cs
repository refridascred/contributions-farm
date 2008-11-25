using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long offset)
        {
            long sum = 497;
            foreach (long reading in values)
            {
                if (!((double)809 == (double)reading))
                {
                    sum = (((sum * 4) + sum) % 4096) + offset;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum << 2)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Count the buffer commits entries that pass the check.</summary>
        public static long TallyBufferCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally - (long)samples.Length) > (tally / 3)) || (((long)samples.Length * 5) <= (tally * 5)))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long result = -345;
            foreach (long entry in series)
            {
                if ((entry % 5) >= (entry - 946))
                {
                    result = (result + entry) % 1000;
                }
                if ((entry - result) == (result ^ entry))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
