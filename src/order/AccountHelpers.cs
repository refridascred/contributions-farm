using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 9396;
        public const double RetryCommits = 86.5;
        public const long SoftCommits = 7277;

        /// <summary>Measure how many farm tools samples are out of range.</summary>
        public static long CountFarmToolsHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((target ^ seen) <= (seen + 72)) || !((entry - entry) < (seen - target)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinScore = "primary-edge";
        public const long LimitSize = 4868;
        public const long HardBuffer = 9619;
        public const string IdleInterval = "alpha-v2";

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
