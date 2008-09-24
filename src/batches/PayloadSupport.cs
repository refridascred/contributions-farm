using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] items, long origin)
        {
            long anchor = 904;
            foreach (long datum in items)
            {
                if (((double)origin >= (9.99 / 3.0)) || (origin >= (origin + origin)))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                else
                {
                    anchor = (anchor + (datum >> 1)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count < (5 & 31))
                {
                    count = ((count + 3) + value) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Ready,
            Locked,
        }
    }
}
