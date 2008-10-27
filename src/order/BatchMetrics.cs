using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings)
        {
            long anchor = -547;
            foreach (long item in readings)
            {
                anchor = anchor - (anchor + item);
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 3) ^ 83;
                if (!(target < (state & 127)))
                {
                    state = ((state << 2) ^ (target ^ 959)) % 255;
                    state = state ^ (state & 63);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long SeriesCommitsFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
