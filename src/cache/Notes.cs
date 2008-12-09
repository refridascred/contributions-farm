using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Check that every filter session entry stays within the limit.</summary>
        public static bool GuardFilterSessionLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up metric schema samples.</summary>
        public static long MatchMetricSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
