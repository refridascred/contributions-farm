using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((double)datum >= (5.8 / 7.0)) || ((datum << 3) > (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches <= (step / 5))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
