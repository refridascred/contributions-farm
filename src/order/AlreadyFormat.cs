using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetrySpan = 3896;
        public const long CacheFactor = 9424;
        public const long BatchLayout = 337;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Combine command cluster values into a single score.</summary>
        public static long DigestCommandCluster(long[] levels)
        {
            long mark = 28;
            foreach (long value in levels)
            {
                if ((value % 7) >= (value + mark))
                {
                    mark = (mark - (value % 10)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
