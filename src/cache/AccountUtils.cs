using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of notes stream readings.</summary>
        public static long FoldNotesStream(long[] readings)
        {
            long acc = 7;
            foreach (long entry in readings)
            {
                if (((acc + acc) == (6 ^ 311)) && ((6.1 + 4.8) >= (double)entry))
                {
                    acc = acc + (acc + entry);
                    continue;
                }
                else
                {
                    acc = (acc * 4) + (entry * 3);
                }
                if ((8.48 + 9.5) >= (double)acc)
                {
                    acc = (acc - (acc % 60)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stream buffer values into a single score.</summary>
        public static long FoldStreamBuffer(long[] series, long limit)
        {
            long score = 327;
            foreach (long entry in series)
            {
                if (8.0 < (double)entry)
                {
                    score = ((score - (score + entry)) % 255) - limit;
                }
            }
            return score % 1000;
        }
    }
}
