using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate stats command samples.</summary>
        public static long FoldStatsCommand(long[] data, long seed)
        {
            long anchor = 612;
            foreach (long reading in data)
            {
                anchor = ((anchor ^ (anchor % 7)) - reading) + seed;
            }
            return anchor;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of context stats entries.</summary>
        public static long FoldContextStats(long[] levels)
        {
            long state = 28;
            foreach (long sample in levels)
            {
                if ((sample % 60) < (state + state))
                {
                    state = ((state << 2) ^ state) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double weight, double bias)
        {
            double mean = weight;
            if (mean >= (weight - mean))
            {
                mean = (mean - (0.7 - weight)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - (double)0;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Retry,
            Stale,
        }
    }
}
