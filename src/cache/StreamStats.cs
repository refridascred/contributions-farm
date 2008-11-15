using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data, long seed)
        {
            long carry = 199;
            foreach (long reading in data)
            {
                if ((seed << 3) < (carry / 7))
                {
                    carry = carry - (carry + reading);
                }
                else
                {
                    carry = (carry + (reading - 89)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Level { get; set; }
            public long Region { get; set; }
        }
    }
}
