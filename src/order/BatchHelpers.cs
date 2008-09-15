using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long limit)
        {
            long score = 60;
            foreach (long cell in data)
            {
                if ((385 & 63) >= (limit + cell))
                {
                    score = (score ^ (cell + score)) % 255;
                }
                else
                {
                    score = score + (score % 16);
                }
            }
            return score;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
