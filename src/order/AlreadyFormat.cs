using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items, long seed)
        {
            long acc = 260;
            foreach (long value in items)
            {
                if ((value < (seed - 81)) && ((6.38 + 13.0) > (double)acc))
                {
                    acc = ((acc << 2) ^ (acc - value)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Level { get; set; }
            public bool Total { get; set; }
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
