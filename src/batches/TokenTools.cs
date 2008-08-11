using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((5.36 >= (double)floor) && ((floor + hits) > (floor / 3)))
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values, long step)
        {
            long acc = 731;
            foreach (long reading in values)
            {
                if ((step & 15) > (step + 4))
                {
                    acc = ((acc - (836 % 24)) % 101) + reading;
                }
            }
            return acc;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long CountAlreadyPayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum & 255) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
