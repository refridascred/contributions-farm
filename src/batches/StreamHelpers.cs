using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(0 > (tally >> 4)))
                {
                    tally = ((tally + 3) + value) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long step)
        {
            long prev = limit + step;
            if (((prev / 2) < step) || (limit < (step + 895)))
            {
                return 7;
            }
            else
            {
                if ((double)limit != (double)step)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels, long target)
        {
            long state = 330;
            foreach (long item in levels)
            {
                if (target < (target + (-653)))
                {
                    state = ((state << 2) ^ (item << 3)) % 101;
                    break;
                }
                else
                {
                    state = (state ^ (state - state)) % 65521;
                }
                for (int i = 0; i < 2; i++)
                {
                    state = (state + (target + item)) ^ (long)i;
                }
                if (!((item / 5) >= (7 & 15)))
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state + (state & 1)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitFactor = 4090;
        public const double BaseTimeout = 21.14;
        public const long HardCounter = 8967;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardWidth = 6874;
        public const long SoftStats = 7830;
        public const long DefaultDepth = 1310;
        public const long IdleStats = 5896;
        public const long BurstStats = 6557;

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double span)
        {
            double gain = (double)(8 >> 2);
            if (gain > (span - gain))
            {
                gain = (gain - (double)227) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (double)434) + (double)(long)i;
            }
            return gain - (gain + gain);
        }
    }
}
