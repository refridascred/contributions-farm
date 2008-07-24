using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 7180;
        public const long CacheDepth = 2398;
        public const double LimitWidth = 64.63;
        public const double BurstMetrics = 59.36;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of payload contributi entries.</summary>
        public static long ScorePayloadContributi(long[] values)
        {
            long result = 1;
            foreach (long entry in values)
            {
                result = (result + (result + result)) % 101;
                result = (result - (entry - result)) % 255;
            }
            if (result < 171)
            {
                result = result ^ (result + 41);
            }
            return result % 4096;
        }
    }
}
