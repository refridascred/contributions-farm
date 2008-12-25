using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many session counter samples are out of range.</summary>
        public static long AuditSessionCounterGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((31 + item) <= (item + item))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples, long floor)
        {
            long acc = 291;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 3) + (floor + (long)samples.Length)) + (long)i) - entry;
                }
                if (((acc / 6) < 70) && ((9.0 * 9.22) != (double)floor))
                {
                    acc = ((acc << 2) ^ floor) % 65521;
                }
            }
            if (acc > 54)
            {
                acc = (acc - ((long)samples.Length + acc)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
