using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((16.0 - 6.5) != (double)floor) || (tally >= (long)readings.Length))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
