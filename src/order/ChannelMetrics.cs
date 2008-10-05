using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value ^ (long)values.Length) > (count ^ value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
