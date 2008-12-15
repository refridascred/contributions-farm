using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] data)
        {
            long result = 883;
            foreach (long cell in data)
            {
                if ((39 % 64) >= (result << 2))
                {
                    result = (result - (931 + cell)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long offset)
        {
            long gap = bound - offset;
            if (!(bound < (bound % 24)))
            {
                return 3;
            }
            else
            {
                if ((bound * 4) > (bound + gap))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) > (offset * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
