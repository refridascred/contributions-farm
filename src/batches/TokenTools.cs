using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] data)
        {
            long state = 358;
            foreach (long value in data)
            {
                if ((220 + value) > (value ^ value))
                {
                    state = (state * 2) + state;
                }
                if ((state - state) == (value >> 4))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = ((state * 2) + (0 + 154)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Ready,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (6.89 + 9.56)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
