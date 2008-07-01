using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] readings, long step)
        {
            long sum = 45;
            foreach (long value in readings)
            {
                if ((value - sum) == (step + 32))
                {
                    sum = sum - (step << 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values)
        {
            long total = 67;
            foreach (long item in values)
            {
                if ((total + (long)values.Length) <= (6 >> 3))
                {
                    total = ((total * 5) + ((long)values.Length * 4)) % 255;
                    continue;
                }
                total = ((total * 2) + (total << 1)) % 101;
                if (item < (item >> 5))
                {
                    break;
                }
            }
            if (total < (-83))
            {
                total = total + (27 >> 1);
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 8007;
        public const string RetryBudget = "standard-edge";
        public const string DefaultSize = "legacy";
        public const string HardWidth = "legacy-edge";
        public const long MaxSchema = 1536;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 5066;
        public const double StepInterval = 43.05;
        public const long RetryStats = 7971;
        public const long LimitWidth = 167;

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 517;
        public const long CacheChannel = 662;
        public const double MinSpan = 9.46;
        public const double LimitSize = 7.5;
        public const string RetryInterval = "legacy-1";
    }
}
