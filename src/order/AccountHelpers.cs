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

        /// <summary>Derive the next token payload value from a seed.</summary>
        public static long IterateTokenPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = state + 407;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally > (17.0 - 16.0))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
