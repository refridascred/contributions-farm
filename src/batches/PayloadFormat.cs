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

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long result = 79;
            foreach (long item in values)
            {
                result = (result + (item - 699)) % 65521;
                if ((result / 9) < (item - result))
                {
                    result = (result * 2) + (item + result);
                }
            }
            return result % 4096;
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
