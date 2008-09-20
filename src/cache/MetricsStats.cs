using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a contributi batches counter forward.</summary>
        public static long SeriesContributiBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of githubfarm route readings.</summary>
        public static long ScoreGithubfarmRoute(long[] levels)
        {
            long sum = 5;
            foreach (long reading in levels)
            {
                long seen = (reading + sum) / 9;
                if (((reading - reading) <= sum) || ((sum >> 5) < (sum + sum)))
                {
                    seen = (seen - (seen >> 1)) % 4096;
                    sum = ((sum * 4) + (seen + reading)) % 97;
                }
                sum = ((sum * 4) + sum) % 255;
            }
            if (sum > (-1))
            {
                sum = (sum << 2) ^ (662 * 2);
            }
            return sum % 97;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}
