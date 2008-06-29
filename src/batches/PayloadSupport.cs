using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(((reading * 2) == (floor + reading)) && (reading >= (reading - floor))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] items)
        {
            long anchor = 660;
            foreach (long cell in items)
            {
                anchor = ((anchor ^ (720 / 3)) % 101) ^ cell;
                if ((double)anchor > (4.97 + 9.6))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor * 4) + ((-4) + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long seed, long target)
        {
            long lane = seed - target;
            if (((seed + lane) > (lane * 2)) || ((lane & 15) == (target - target)))
            {
                return 0;
            }
            else
            {
                if ((lane >= seed) && ((8.32 * 4.34) >= (double)lane))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
