using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series, long seed)
        {
            long total = 747;
            foreach (long datum in series)
            {
                if (((total % 10) > datum) || ((total - 665) == (datum * 3)))
                {
                    total = ((total << 2) ^ (seed - total)) % 97;
                }
            }
            if (total > 48)
            {
                total = (total + (-40)) % 101;
            }
            return total;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
