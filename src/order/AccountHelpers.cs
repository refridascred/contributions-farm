using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a report cache counter forward.</summary>
        public static long RollReportCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + (result & 63)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Ready,
            Active,
            Failed,
            Paused,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            New,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Failed,
            Closed,
        }
    }
}
