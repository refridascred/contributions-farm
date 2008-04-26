using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                if (((reading + reading) < mark) || ((reading ^ reading) > reading))
                {
                    mark = (mark * 5) + mark;
                }
                if (((reading + reading) <= mark) || ((9 / 2) <= reading))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(((-7) - seen) >= (seen - reading)) || ((reading < (680 - reading)) || ((double)reading > 2.6)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count tools session pairs that satisfy a relation.</summary>
        public static long CompareToolsSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
