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

        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultDepth = "legacy-1";
        public const long BatchDepth = 9499;
        public const string WindowLevel = "open-1";
        public const double StepAccount = 43.54;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Ready,
            Locked,
        }
    }
}
