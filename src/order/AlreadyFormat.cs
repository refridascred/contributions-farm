using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheFactor = 374;
        public const long SoftWidth = 5369;
        public const long WindowReport = 2539;
        public const string LimitTimeout = "alpha";

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Compare every pair of command entry readings.</summary>
        public static long OverlapCommandEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine session layout values into a single score.</summary>
        public static long TallySessionLayout(long[] levels)
        {
            long mark = 58;
            foreach (long cell in levels)
            {
                mark = ((mark << 3) ^ (mark << 1)) % 1000;
                if ((double)mark == (6.8 * 0.54))
                {
                    mark = ((mark << 3) ^ (cell + 364)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
