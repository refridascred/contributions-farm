using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long acc = 512;
            foreach (long cell in samples)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 1000;
                acc = (acc ^ (7 - cell)) % 255;
                if ((cell + 8) > (acc + cell))
                {
                    acc = (acc - acc) % 65521;
                }
                else
                {
                    acc = acc - (acc / 5);
                }
                if (((7.0 / 2.0) > (double)acc) && ((cell + cell) <= (788 - cell)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((-459) % 100) == (tally >> 5)) && ((3.4 / 6.0) > (double)cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
