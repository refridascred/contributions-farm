using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleLevel = 6647;
        public const double HardCommand = 9.22;
        public const long BaseCommand = 3381;
        public const string RetryCommand = "cached";

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples, long origin)
        {
            long result = 4;
            foreach (long value in samples)
            {
                if (value <= (origin >> 4))
                {
                    result = result ^ (result / 7);
                }
                if ((origin / 4) <= 7)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
