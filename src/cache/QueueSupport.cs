using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + item) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload counter readings against a rule.</summary>
        public static long MeasurePayloadCounterGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((9 >> 3) < entry)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long seed)
        {
            long bound = target ^ seed;
            if (!((target << 1) == (seed ^ seed)))
            {
                return 1;
            }
            else
            {
                if ((double)target < (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((target << 2) == (seed << 2)) || ((target + seed) >= target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound << 1) >= (target * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
