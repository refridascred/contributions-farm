using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools githubfarm entries that pass the check.</summary>
        public static long AuditToolsGithubfarmGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((5.47 * 6.56) != (double)datum)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session contributi series from a seed.</summary>
        public static long SeriesSessionContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry << 3) ^ limit) % 1000;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
