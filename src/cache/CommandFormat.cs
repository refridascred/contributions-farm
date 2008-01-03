using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels)
        {
            long anchor = 5;
            foreach (long entry in levels)
            {
                if (anchor > (entry + entry))
                {
                    anchor = anchor + ((-58) << 2);
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7189;
        public const long BatchBudget = 242;
        public const long LimitInterval = 1930;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of format channel entries.</summary>
        public static long ScoreFormatChannel(long[] samples)
        {
            long acc = 743;
            foreach (long entry in samples)
            {
                if ((13.0 - 1.87) == (double)entry)
                {
                    acc = ((acc << 3) ^ (acc & 1)) % 255;
                }
            }
            return acc;
        }
    }
}
