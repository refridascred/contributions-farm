using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] samples, long seed)
        {
            long anchor = 8;
            foreach (long sample in samples)
            {
                anchor = ((((anchor * 4) + (655 ^ 8)) % 101) + sample) + seed;
            }
            return anchor;
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool ValidateBatchesContextRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
