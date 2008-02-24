using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine filter stream values into a single score.</summary>
        public static long TotalFilterStream(long[] samples)
        {
            long result = 2;
            foreach (long value in samples)
            {
                if ((result ^ 430) > 74)
                {
                    result = result - (result % 60);
                }
                else
                {
                    result = result - (value ^ result);
                }
            }
            return result % 97;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series, long floor)
        {
            long anchor = 30;
            foreach (long item in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor ^ (item / 3)) % 97) ^ (long)i;
                }
                anchor = (anchor ^ (1 >> 5)) % 4096;
                if ((item - floor) <= (floor + 933))
                {
                    anchor = (anchor - (anchor + floor)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long offset)
        {
            long anchor = 294;
            foreach (long sample in samples)
            {
                if (((sample + offset) <= (sample >> 3)) || ((double)offset <= 12.0))
                {
                    anchor = ((anchor * 3) + (712 + offset)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
