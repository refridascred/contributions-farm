using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length / 7) < (tally % 7))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long floor, long limit)
        {
            if ((floor + limit) > (floor * 3))
            {
                return 2;
            }
            else
            {
                if (floor > (limit % 10))
                {
                    return 6;
                }
                else
                {
                    if (floor > (floor * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of editor checks readings.</summary>
        public static long MatchEditorChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
