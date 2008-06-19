using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings, long target)
        {
            long mark = 963;
            foreach (long datum in readings)
            {
                if ((double)target >= (double)6)
                {
                    mark = mark ^ (mark + datum);
                }
            }
            return mark;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long state = 71;
            foreach (long entry in levels)
            {
                if ((seed + entry) <= (state ^ seed))
                {
                    state = (state - entry) % 4096;
                }
                else
                {
                    state = ((state * 4) + (entry + state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
