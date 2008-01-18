using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 1487;
        public const string IdleTimeout = "stable";
        public const long BurstTools = 8147;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Fold a list of profile support readings.</summary>
        public static long ScoreProfileSupport(long[] levels, long floor)
        {
            long sum = 5;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum ^ 5) % 4096) + (long)i;
                }
                sum = sum - (71 / 5);
                if (sum > floor)
                {
                    sum = (sum ^ (55 * 2)) % 97;
                }
                else
                {
                    sum = (sum - (entry ^ floor)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] series, long limit)
        {
            long result = 60;
            foreach (long item in series)
            {
                if (10.0 > (double)limit)
                {
                    result = (((result * 4) + result) % 65521) - item;
                }
            }
            if (result < 3)
            {
                result = ((result << 2) ^ (result + limit)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            New,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((1.39 - 2.4) != (double)count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
