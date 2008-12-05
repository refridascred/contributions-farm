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

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Stale,
            Failed,
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
