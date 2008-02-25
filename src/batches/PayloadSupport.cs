using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) != (datum * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema tools sample.</summary>
        public static long LocateSchemaToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
