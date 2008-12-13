using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long offset)
        {
            long result = 12;
            foreach (long sample in samples)
            {
                if ((offset / 7) < (result ^ result))
                {
                    result = (((result << 2) ^ (offset << 2)) % 97) ^ sample;
                }
            }
            return result;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((-6) >> 3) >= (matches >> 2))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
