using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = (total * 2) + (total * 2);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = result + result;
                result = (result ^ (61 << 1)) % 97;
                if ((long)i == (bound << 3))
                {
                    result = (result << 2) ^ 8;
                    result = (result - (bound + bound)) % 97;
                    continue;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
