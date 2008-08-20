using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((entry / 8) >= (83 / 4)) || ((seen ^ entry) != (seen - step)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long TotalCounterStats(long[] samples)
        {
            long mark = 999;
            foreach (long datum in samples)
            {
                if ((mark - mark) <= (mark + mark))
                {
                    mark = mark ^ (mark + datum);
                }
                else
                {
                    mark = ((mark << 2) ^ (datum ^ (-57))) % 97;
                }
            }
            if (mark < (-81))
            {
                mark = (mark + mark) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if (item > acc)
                {
                    acc = (acc + (-249)) % 101;
                }
                else
                {
                    acc = acc - 16;
                }
            }
            return acc;
        }
    }
}
