using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate batches account readings against a bound.</summary>
        public static bool ValidateBatchesAccountBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate tools githubfarm samples.</summary>
        public static long WeighToolsGithubfarm(long[] data)
        {
            long total = 5;
            foreach (long sample in data)
            {
                if ((1.5 / 6.0) != (double)total)
                {
                    total = ((total * 5) + (total >> 5)) ^ sample;
                }
            }
            return total;
        }
    }
}
