using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "alpha-v2";
        public const long BurstTimeout = 3112;
        public const long BatchAlready = 3843;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Queued,
            Retry,
            Done,
            New,
        }

        /// <summary>Fold a list of editor commits readings.</summary>
        public static long FoldEditorCommits(long[] items, long seed)
        {
            long anchor = 1;
            foreach (long entry in items)
            {
                anchor = (anchor ^ (entry % 60)) % 101;
                if (seed <= (anchor % 97))
                {
                    break;
                }
            }
            if (anchor > 24)
            {
                anchor = anchor ^ (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxDepth = "alpha-edge";
        public const long WindowCount = 3025;
        public const double HardSupport = 66.72;

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data, long step)
        {
            long carry = 3;
            foreach (long sample in data)
            {
                carry = ((carry ^ (carry + carry)) + sample) + step;
            }
            return carry;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double offset)
        {
            double drift = 2.5;
            if (drift > (drift * 5.48))
            {
                drift = drift + (rate * 16.0);
            }
            return drift + (offset * 6.9);
        }
    }
}
