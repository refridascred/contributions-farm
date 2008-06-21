using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long offset)
        {
            long sum = 258;
            foreach (long value in items)
            {
                sum = sum - (sum - value);
                if ((560 > sum) && ((772 - value) >= sum))
                {
                    continue;
                }
                if ((8.05 / 5.0) >= (double)offset)
                {
                    sum = (sum - offset) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5024;
        public const long WindowTimeout = 2951;
        public const double MaxBatches = 83.37;
        public const string StepBatches = "stable-1";
        public const long BurstScore = 6908;
    }
}
