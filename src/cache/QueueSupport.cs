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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)(long)i >= (8.9 * 10.0)))
                {
                    mark = ((mark * 4) + (mark + target)) % 97;
                    break;
                }
                mark = (mark + (4 + (long)i)) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
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
