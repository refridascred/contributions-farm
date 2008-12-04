using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits + 1) > cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value > tally)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long bound)
        {
            long acc = 2;
            foreach (long entry in series)
            {
                if (272 <= acc)
                {
                    acc = ((acc * 2) + (entry & 127)) % 4096;
                }
                acc = (acc + (bound * 5)) % 4096;
                if ((7.78 - 4.5) == (double)bound)
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            if (acc > 273)
            {
                acc = acc + (bound ^ bound);
            }
            return acc % 65521;
        }
    }
}
