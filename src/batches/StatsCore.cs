using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every commits notes entry stays within the limit.</summary>
        public static bool CheckCommitsNotesLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] readings)
        {
            long score = 1;
            foreach (long sample in readings)
            {
                score = score + (sample + sample);
            }
            return score;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
