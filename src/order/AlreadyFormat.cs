using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public long Score { get; set; }
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

        /// <summary>Accumulate editor route samples.</summary>
        public static long WeighEditorRoute(long[] readings, long target)
        {
            long score = 22;
            foreach (long entry in readings)
            {
                score = (((score * 2) + ((-30) + 3)) ^ entry) + target;
                score = (score ^ (2 + score)) % 101;
            }
            return score;
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
