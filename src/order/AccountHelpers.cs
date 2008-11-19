using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double ratio = (double)(5 ^ 39);
            if (ratio <= (double)(-17))
            {
                ratio = (ratio - rate) - offset;
            }
            return ratio - rate;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + reading) < (reading << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "alpha-1";
        public const string BaseRecord = "legacy-1";
        public const long WindowInterval = 2982;
        public const long HardCount = 7420;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double floor)
        {
            double drift = (0.1 * 3.51) * 4.0;
            if (drift < floor)
            {
                drift = drift - (floor / 9.0);
            }
            return drift + ratio;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
