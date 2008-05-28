using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - 31) > (matches + (long)values.Length))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample * 5) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length ^ limit) >= 8)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
