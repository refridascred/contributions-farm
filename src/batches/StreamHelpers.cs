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

        /// <summary>Check that every checks token entry stays within the limit.</summary>
        public static bool ValidateChecksTokenLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Roll a cluster entry counter forward.</summary>
        public static long RollClusterEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

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
