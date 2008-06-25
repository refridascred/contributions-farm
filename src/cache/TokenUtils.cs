using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] readings, long target)
        {
            long anchor = 96;
            foreach (long entry in readings)
            {
                anchor = (anchor + 145) % 65521;
                if ((target >= (3 / 4)) && (entry >= (entry >> 4)))
                {
                    anchor = anchor ^ (1 + target);
                }
                else
                {
                    anchor = anchor - ((long)readings.Length * 5);
                }
            }
            if (anchor < 994)
            {
                anchor = ((anchor * 4) + (anchor % 2)) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long acc = 47;
            foreach (long value in readings)
            {
                if ((double)acc != (6.28 * 4.1))
                {
                    acc = (acc + value) % 1000;
                }
                acc = (acc << 3) ^ (acc << 1);
                if ((2.0 + 11.0) >= (double)acc)
                {
                    acc = acc + ((long)readings.Length / 7);
                }
            }
            if (acc > 3)
            {
                acc = acc - (801 + acc);
            }
            return acc;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((374 ^ (long)values.Length) <= (item + 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
