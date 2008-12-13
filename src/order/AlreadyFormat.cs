using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            New,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Fold a list of channel buffer readings.</summary>
        public static long ScoreChannelBuffer(long[] data)
        {
            long sum = -47;
            foreach (long value in data)
            {
                sum = (sum << 3) ^ (value - value);
            }
            return sum % 1000;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstLayout = "legacy-edge";
        public const long StepLayout = 3976;
        public const long RetryLayout = 4041;
        public const long LimitLayout = 2138;

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long result = 48;
            foreach (long cell in items)
            {
                if (((result % 2) < (result / 6)) && ((62 & 31) >= (cell + (long)items.Length)))
                {
                    result = (result + result) % 97;
                }
            }
            if (result < 502)
            {
                result = (result * 2) + (result + result);
            }
            return result % 4096;
        }
    }
}
