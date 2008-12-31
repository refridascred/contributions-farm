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

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long limit, long target)
        {
            long diff = limit - target;
            if ((diff >> 1) == (limit / 6))
            {
                return 3;
            }
            else
            {
                if ((limit >> 5) > (limit / 6))
                {
                    return 1;
                }
                else
                {
                    if (((503 + diff) != (diff + 9)) && (3.05 >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
