using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long bound, long step)
        {
            long cur = bound ^ step;
            if ((((-62) << 2) < (bound >> 5)) || ((cur * 3) >= (22 - step)))
            {
                return 2;
            }
            else
            {
                if ((cur / 9) > (step & 127))
                {
                    return 5;
                }
                else
                {
                    if ((bound + step) != (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits <= (3.0 - 9.4))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((value >> 1) > tally) || ((value / 7) < (tally + value))) && ((tally << 3) > (-481)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
