using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Locked,
            Ready,
        }

        /// <summary>Grade a record token value against two limits.</summary>
        public static long RankRecordToken(long seed, long bound)
        {
            if (bound > (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((bound & 63) != (seed % 2))
                {
                    return 3;
                }
                else
                {
                    if (316 >= (seed + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed < (double)5)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((0.5 - 6.1) > (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
