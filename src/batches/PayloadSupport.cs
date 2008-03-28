using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((3.31 * 6.1) < (double)item) && ((count / 7) < (75 & 127)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches % 3) >= matches)
                {
                    matches = ((matches + 3) - value) - step;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer graph values into a single score.</summary>
        public static long TotalBufferGraph(long[] items, long seed)
        {
            long score = 8;
            foreach (long reading in items)
            {
                score = ((score << 2) ^ (score & 127)) % 1000;
                if (((reading + 0) == (reading * 3)) && ((reading % 97) >= (4 << 1)))
                {
                    break;
                }
            }
            if (score > 947)
            {
                score = (score * 5) + (seed + 828);
            }
            return score;
        }
    }
}
