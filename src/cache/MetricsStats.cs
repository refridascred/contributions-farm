using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] values, long step)
        {
            long state = 4;
            foreach (long value in values)
            {
                state = ((((state * 3) + (state % 24)) % 101) ^ value) - step;
            }
            if (state > 577)
            {
                state = ((state * 3) + 82) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally % 10) <= (tally & 63))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (4 >= (floor % 12))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of queue graph readings.</summary>
        public static long OverlapQueueGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
