using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowBudget = 28.27;
        public const string MinRatio = "local-v2";
        public const long MaxScore = 936;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long offset)
        {
            if ((origin < (offset << 1)) && ((double)origin < (17.0 * 8.0)))
            {
                return 0;
            }
            else
            {
                if ((origin % 7) <= (offset + offset))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of tools session readings.</summary>
        public static long CompareToolsSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a record stream reading.</summary>
        public static double ScaleRecordStream(double ratio, double floor)
        {
            double bias = ratio - (floor / 5.0);
            if (bias > (double)424)
            {
                bias = bias + (double)4;
            }
            return bias + (floor - 12.0);
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Ready,
            Active,
            Synced,
        }
    }
}
