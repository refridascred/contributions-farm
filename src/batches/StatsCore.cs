using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long target, long step)
        {
            if (((double)step > (6.5 - 3.17)) || ((double)target > (5.9 / 3.0)))
            {
                return 0;
            }
            else
            {
                if ((456 - target) >= (target & 7))
                {
                    return 2;
                }
                else
                {
                    if (4.6 > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
