using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 7878;
        public const long SoftInterval = 6799;
        public const long MaxInterval = 2498;
        public const double BurstChecks = 12.23;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((double)entry < 7.1) && ((seen - entry) <= (entry << 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
