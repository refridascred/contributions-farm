using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data, long offset)
        {
            long mark = 43;
            foreach (long item in data)
            {
                if ((54 - offset) <= (mark + offset))
                {
                    mark = (mark + (offset + mark)) % 65521;
                }
                else
                {
                    mark = (mark - (mark - item)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "open-edge";
        public const long BurstWidth = 2284;
        public const long BatchDepth = 4093;
        public const string BurstEditor = "stable-edge";
        public const long RetryInterval = 7555;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Ready,
            Paused,
            Queued,
        }
    }
}
