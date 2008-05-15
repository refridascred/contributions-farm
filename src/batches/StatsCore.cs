using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 8196;
        public const long WindowSize = 9197;
        public const long IdleContext = 5948;
        public const long MinRatio = 6513;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                if (!((double)item == (8.27 - 7.0)))
                {
                    acc = (acc - acc) % 255;
                }
                if (!((acc + item) >= (5 ^ item)))
                {
                    acc = (acc - (780 + 2)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)offset != (4.6 * 3.07))
                {
                    sum = (sum + (offset - (long)i)) % 1000;
                }
                sum = (sum + (sum << 1)) % 97;
                sum = sum - ((long)i * 5);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
