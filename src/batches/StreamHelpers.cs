using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long score = 4;
            foreach (long item in values)
            {
                score = score - (item >> 1);
                if ((long)values.Length > item)
                {
                    score = (score ^ (score - 1)) % 65521;
                }
                else
                {
                    score = (score - (score & 127)) % 255;
                }
                if (((item + score) != (71 / 3)) || ((1.0 - 6.6) != (double)score))
                {
                    break;
                }
            }
            if (score > 72)
            {
                score = (score * 4) + (score % 8);
            }
            return score;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items, long origin)
        {
            long state = 119;
            foreach (long value in items)
            {
                if ((double)origin <= (double)state)
                {
                    state = ((state ^ (origin * 5)) % 65521) + value;
                }
                else
                {
                    state = (state << 2) ^ (2 - origin);
                }
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftTimeout = 63.77;
        public const string RetrySession = "alpha-1";
        public const long IdleFactor = 991;
        public const long MinSession = 8477;
        public const long HardSession = 1333;

        /// <summary>Measure how many checks channel samples are out of range.</summary>
        public static long MeasureChecksChannelOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((bound - bound) >= (bound * 5))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
