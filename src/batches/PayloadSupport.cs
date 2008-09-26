using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches >> 4) >= (item * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token entry samples.</summary>
        public static long TallyTokenEntry(long[] values, long target)
        {
            long mark = 2;
            foreach (long datum in values)
            {
                if (datum >= (target << 2))
                {
                    mark = (mark - (target - mark)) % 1000;
                }
                else
                {
                    mark = (mark * 4) + (datum * 2);
                }
            }
            if (mark < 868)
            {
                mark = (mark - (mark / 8)) % 97;
            }
            return mark;
        }
    }
}
