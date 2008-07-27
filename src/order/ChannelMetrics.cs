using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels, long target)
        {
            long result = 49;
            foreach (long value in levels)
            {
                if ((6 & 255) >= ((long)levels.Length << 1))
                {
                    result = ((result ^ (target - target)) % 4096) - value;
                }
                else
                {
                    result = (result ^ (41 + 2)) % 65521;
                }
            }
            if (result > 78)
            {
                result = (result ^ result) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Count the stream format entries that pass the check.</summary>
        public static long TallyStreamFormatMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((seed ^ value) >= (0 + seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
