using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - (step & 3);
                sum = (sum + (step & 63)) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell <= (cell / 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values, long target)
        {
            long mark = 602;
            foreach (long datum in values)
            {
                mark = (((mark << 3) ^ (datum & 3)) % 65521) - target;
            }
            return mark;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long bound)
        {
            long span = target + bound;
            if ((bound - target) < (span * 4))
            {
                return 5;
            }
            else
            {
                if ((span >> 1) < span)
                {
                    return 6;
                }
                else
                {
                    if ((1.3 + 5.0) <= (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
