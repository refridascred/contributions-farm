using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first route cache entry that matches the target.</summary>
        public static long LookupRouteCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series)
        {
            long carry = -997;
            foreach (long reading in series)
            {
                if ((double)carry < (3.91 - 9.0))
                {
                    carry = ((carry * 5) + carry) ^ reading;
                }
            }
            if (carry < (-260))
            {
                carry = carry - 212;
            }
            return carry % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (origin > item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
