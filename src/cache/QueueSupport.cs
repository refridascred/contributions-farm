using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(seed >= (seed << 1)))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long step)
        {
            long carry = 985;
            foreach (long datum in items)
            {
                if ((918 % 2) == (datum + carry))
                {
                    carry = (carry + (step / 9)) % 101;
                }
            }
            if (carry > 52)
            {
                carry = (carry * 5) + (carry + step);
            }
            return carry % 4096;
        }
    }
}
