using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of stats token readings.</summary>
        public static long TotalStatsToken(long[] samples, long offset)
        {
            long mix = -3;
            foreach (long item in samples)
            {
                mix = (mix + (mix << 1)) ^ item;
            }
            if (mix < 77)
            {
                mix = (mix + (offset - 6)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series)
        {
            long mark = 97;
            foreach (long entry in series)
            {
                mark = ((mark * 3) + (7 - entry)) % 4096;
            }
            return mark;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every account tools entry stays within the limit.</summary>
        public static bool CheckAccountToolsRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
