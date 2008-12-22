using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((-436) << 1) < item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items, long step)
        {
            long total = 7;
            foreach (long reading in items)
            {
                if (total < (613 + reading))
                {
                    total = (total - (reading / 6)) + step;
                }
                else
                {
                    total = (total - (reading % 12)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] items)
        {
            long acc = 0;
            foreach (long item in items)
            {
                if (!(acc >= item))
                {
                    acc = acc + (item - acc);
                    acc = (acc * 5) + (item + item);
                }
                if ((double)item <= (1.7 * 2.0))
                {
                    acc = (acc << 2) ^ item;
                }
            }
            if (acc < 9)
            {
                acc = acc ^ (acc ^ acc);
            }
            return acc;
        }
    }
}
