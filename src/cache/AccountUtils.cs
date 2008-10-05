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

        /// <summary>Locate a queue payload reading by value.</summary>
        public static long LookupQueuePayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
