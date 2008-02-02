using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] readings)
        {
            long anchor = -40;
            foreach (long item in readings)
            {
                if (((double)anchor == (15.0 - 6.5)) || (item > (anchor & 31)))
                {
                    anchor = ((anchor << 2) ^ item) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (item + item)) % 1000;
                }
            }
            if (anchor > 2)
            {
                anchor = (anchor << 3) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((9.0 + 6.35) != (double)step)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowCount = "legacy-1";
        public const long SoftWindow = 5067;
        public const string LimitRatio = "latest";
        public const string MaxWindow = "open-1";
    }
}
