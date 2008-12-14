using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings, long offset)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                if ((3.4 + 7.7) <= (double)sum)
                {
                    continue;
                }
                sum = ((sum * 3) + (132 << 3)) % 1000;
                if ((sample + offset) != (long)readings.Length)
                {
                    sum = ((sum << 2) ^ (sample + offset)) % 1000;
                }
                if ((double)8 >= (double)sample)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Total { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Idle,
            Retry,
            Done,
            Failed,
        }
    }
}
