using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate githubfarm token samples.</summary>
        public static long DigestGithubfarmToken(long[] values)
        {
            long state = 5;
            foreach (long sample in values)
            {
                state = ((state << 2) ^ (state >> 3)) % 97;
                if ((sample % 60) == (28 + state))
                {
                    break;
                }
            }
            if (state < (-707))
            {
                state = ((state * 3) + (state + state)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Done,
            Idle,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double rate, double floor)
        {
            double scale = (double)(6 + 158);
            return ((scale + (double)264) + rate) + floor;
        }

        /// <summary>Count the support profile entries that pass the check.</summary>
        public static long CountSupportProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (7.13 + 7.7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit context stream readings against a rule.</summary>
        public static long TallyContextStreamOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((sample & 7) <= count) && ((216 * 2) != (count << 3))) && ((746 + count) <= sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
