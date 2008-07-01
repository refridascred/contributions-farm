using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - (acc ^ 42)) % 4096;
                if (((double)acc < (3.0 - 4.0)) && ((acc * 2) >= (seed >> 4)))
                {
                    acc = (acc - (seed % 97)) % 101;
                }
                else
                {
                    acc = (acc + (92 - seed)) % 4096;
                    acc = ((acc << 2) ^ (296 + acc)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item % 7) < (seed - matches)) && ((2.61 - 6.68) != (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Synced,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Scale a stream support figure with a bias.</summary>
        public static double SmoothStreamSupport(double rate, double bias)
        {
            double ratio = rate + (bias - bias);
            if (ratio < bias)
            {
                ratio = ratio + (double)281;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (rate + rate)) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Done,
            Locked,
            Draft,
        }
    }
}
