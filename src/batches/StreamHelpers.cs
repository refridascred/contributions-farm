using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] readings)
        {
            long carry = 17;
            foreach (long item in readings)
            {
                if ((double)carry > (19.0 + 8.0))
                {
                    carry = ((carry ^ (carry + (-1))) % 1000) ^ item;
                }
            }
            if (carry < 600)
            {
                carry = (carry ^ (carry >> 4)) % 255;
            }
            return carry;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Roll a route already counter forward.</summary>
        public static long DeriveRouteAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total - (total + origin)) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
