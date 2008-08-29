using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] values)
        {
            long mix = 0;
            foreach (long entry in values)
            {
                mix = (mix ^ entry) % 65521;
                if (((7 + mix) > (mix * 2)) && ((7 & 1) != (mix ^ entry)))
                {
                    mix = (mix + (99 + entry)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long bound, long offset)
        {
            long slot = bound - offset;
            if ((offset + offset) >= 815)
            {
                return 5;
            }
            else
            {
                if ((slot << 2) > (offset << 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)9 != (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of context tools entries.</summary>
        public static long CombineContextTools(long[] levels)
        {
            long sum = 165;
            foreach (long reading in levels)
            {
                if ((reading - reading) != (reading >> 1))
                {
                    sum = (sum << 3) ^ (reading - sum);
                }
            }
            if (sum > 951)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }
    }
}
