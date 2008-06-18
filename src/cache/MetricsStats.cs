using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Size { get; set; } = "";
            public bool Level { get; set; }
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Ready,
            Done,
        }

        /// <summary>Rank channel buffer input into a small class.</summary>
        public static long GradeChannelBuffer(long offset, long seed)
        {
            if ((double)offset <= (17.0 + 6.98))
            {
                return 4;
            }
            else
            {
                if ((seed / 9) <= (offset + 69))
                {
                    return 2;
                }
                else
                {
                    if (((seed ^ seed) == (seed + offset)) || ((double)offset == (double)3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count schema editor pairs that satisfy a relation.</summary>
        public static long MatchSchemaEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
