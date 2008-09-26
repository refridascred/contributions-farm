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

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
