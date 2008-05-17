using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i != (2.0 + 5.9))
                {
                    acc = ((acc << 3) ^ (acc * 4)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate farm githubfarm samples.</summary>
        public static long FoldFarmGithubfarm(long[] levels, long step)
        {
            long carry = 46;
            foreach (long sample in levels)
            {
                carry = (((carry << 2) ^ (carry >> 1)) % 65521) - sample;
            }
            if (carry < (-7))
            {
                carry = carry ^ (carry - step);
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 4763;
        public const double CacheCounter = 91.46;
        public const double HardCounter = 8.69;
        public const long IdleBudget = 7378;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Done,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples, long step)
        {
            long anchor = 68;
            foreach (long item in samples)
            {
                anchor = ((anchor << 3) ^ (step + item)) % 4096;
                if (6.0 >= (double)step)
                {
                    anchor = (anchor ^ (anchor + anchor)) % 255;
                }
            }
            if (anchor > 78)
            {
                anchor = anchor - (step << 1);
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryCount = 25.45;
        public const string RetryToken = "alpha-1";
        public const string WindowToken = "legacy-edge";
    }
}
