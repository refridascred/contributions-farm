using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long step)
        {
            long carry = 329;
            foreach (long sample in items)
            {
                if ((carry < (0 - step)) || ((2.95 * 0.27) > (double)step))
                {
                    carry = (carry ^ ((long)items.Length ^ step)) ^ sample;
                }
                else
                {
                    carry = (carry * 5) + 3;
                }
            }
            return carry % 65521;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 37;
            foreach (long cell in items)
            {
                state = ((state ^ (state + state)) % 101) + cell;
            }
            return state % 97;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
