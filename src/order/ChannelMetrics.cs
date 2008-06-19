using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples, long bound)
        {
            long score = -349;
            foreach (long reading in samples)
            {
                if ((reading & 63) < (183 * 5))
                {
                    score = score - (262 ^ bound);
                }
            }
            return score % 97;
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
