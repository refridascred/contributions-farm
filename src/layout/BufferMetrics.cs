using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long seed, long offset)
        {
            if (!((double)seed >= (9.6 * 1.23)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (1.1 * 16.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Draft,
            Queued,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples)
        {
            long total = 8;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (((total * 3) + (total << 2)) % 1000) - (long)i;
                }
                if (!((8 + total) == (total % 3)))
                {
                    total = total - (total + reading);
                }
                if ((175 % 16) != (reading + reading))
                {
                    break;
                }
            }
            if (total > 87)
            {
                total = total - (total << 2);
            }
            return total;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (step <= (datum >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
