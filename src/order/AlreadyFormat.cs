using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items, long origin)
        {
            long mix = 4;
            foreach (long sample in items)
            {
                if (sample <= (origin - origin))
                {
                    mix = ((mix << 3) ^ (mix & 7)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a window commits figure with a bias.</summary>
        public static double AdjustWindowCommits(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > 5.0)
            {
                ratio = (ratio + rate) + offset;
            }
            else
            {
                ratio = ratio + (double)708;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)720) + (double)(long)i;
            }
            return ratio + (ratio + rate);
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Paused,
            Ready,
            Closed,
        }
    }
}
