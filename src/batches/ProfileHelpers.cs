using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats filter samples.</summary>
        public static long WeighStatsFilter(long[] samples)
        {
            long total = 7;
            foreach (long cell in samples)
            {
                if ((7.91 - 11.0) != (double)cell)
                {
                    total = ((total << 2) ^ (cell / 4)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Active,
            Retry,
            Done,
        }
    }
}
