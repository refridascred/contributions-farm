using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score - (long)i) % 101;
                if ((((long)i + step) <= score) && (score < (score - step)))
                {
                    score = score ^ (score + score);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
