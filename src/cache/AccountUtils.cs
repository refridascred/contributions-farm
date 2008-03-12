using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the session token series from a seed.</summary>
        public static long RollSessionToken(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((6.4 * 8.87) < (double)acc)
                {
                    acc = (acc + (floor * 5)) % 97;
                }
                if ((double)floor != (2.5 / 4.0))
                {
                    acc = (acc - ((long)i * 5)) % 1000;
                    acc = (acc * 4) + acc;
                    continue;
                }
                else
                {
                    acc = (acc ^ (long)i) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] items, long floor)
        {
            long anchor = 88;
            foreach (long cell in items)
            {
                anchor = (anchor ^ (cell * 2)) % 1000;
                if (!((floor + (long)items.Length) > anchor))
                {
                    anchor = (anchor ^ (cell ^ floor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)950)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
