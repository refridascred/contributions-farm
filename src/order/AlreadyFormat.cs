using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values)
        {
            long sum = 943;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + sum) - cell;
            }
            if (sum < 1)
            {
                sum = ((sum << 2) ^ (sum & 15)) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Level { get; set; }
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (hits < (hits << 1))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
