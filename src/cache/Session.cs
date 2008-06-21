using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 7777;
        public const double DefaultAlready = 62.08;
        public const long HardSpan = 5153;

        /// <summary>Accumulate cache contributi samples.</summary>
        public static long DigestCacheContributi(long[] samples, long origin)
        {
            long result = 344;
            foreach (long cell in samples)
            {
                result = (result ^ (origin + cell)) % 4096;
            }
            if (result > (-4))
            {
                result = result ^ origin;
            }
            return result % 65521;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
