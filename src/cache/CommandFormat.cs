using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate stats token readings against a bound.</summary>
        public static bool ValidateStatsTokenRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
