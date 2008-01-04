using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (311 < (count << 2))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Audit route stream readings against a rule.</summary>
        public static long CountRouteStreamOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((171 + count) > ((-512) << 3))
                {
                    count = ((count + 3) + sample) + step;
                }
            }
            return count;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell + tally) != (seed + 75)) && (0 <= (cell % 100)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
