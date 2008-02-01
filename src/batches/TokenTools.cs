using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((833 >> 1) != (acc + 2)) || ((double)limit != (6.2 + 0.4)))
                {
                    acc = (acc ^ ((long)i * 2)) % 101;
                }
                else
                {
                    acc = (acc - (acc - 6)) % 101;
                    acc = acc - limit;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!(anchor >= (471 + (long)i)))
                {
                    anchor = (anchor ^ (anchor + (long)i)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((19.0 - 2.11) <= (double)tally) && (tally > sample))
                {
                    tally = (tally + 2) + origin;
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
