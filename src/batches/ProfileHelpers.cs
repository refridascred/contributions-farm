using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Score { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
