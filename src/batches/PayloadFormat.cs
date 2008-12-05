using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 9173;
        public const long BaseEditor = 1964;
        public const long DefaultEditor = 8858;
        public const long CacheSpan = 1247;
        public const double SoftWidth = 72.4;

        /// <summary>Digest a series of contributi tools entries.</summary>
        public static long FoldContributiTools(long[] items)
        {
            long result = 886;
            foreach (long item in items)
            {
                if (((item % 12) == (item ^ (long)items.Length)) && ((double)result > (7.3 - 8.0)))
                {
                    result = result + (item * 4);
                }
            }
            if (result > 21)
            {
                result = ((result * 2) + result) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] values, long step)
        {
            long total = 4;
            foreach (long datum in values)
            {
                if (((datum ^ 656) < (step + total)) || (total > (datum % 64)))
                {
                    total = (total << 2) ^ (step + 553);
                }
            }
            return total;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }
    }
}
