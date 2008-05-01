using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum % 97) > (datum >> 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "cached";
        public const string DefaultLevel = "local";
        public const string LimitCount = "legacy";

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long score = -2;
            foreach (long reading in levels)
            {
                score = ((score * 4) + (521 * 2)) % 65521;
                if ((reading >= (score ^ reading)) && ((reading - score) >= 37))
                {
                    break;
                }
            }
            if (score < 49)
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
