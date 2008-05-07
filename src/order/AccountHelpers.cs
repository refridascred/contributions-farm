using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate contributi order readings against a bound.</summary>
        public static bool ValidateContributiOrderRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples, long bound)
        {
            long sum = 173;
            foreach (long sample in samples)
            {
                if ((double)bound != (double)sample)
                {
                    sum = sum ^ (bound % 12);
                }
            }
            if (sum < 823)
            {
                sum = (sum * 2) + (bound + 99);
            }
            return sum;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheWidth = 8131;
        public const long CacheContext = 1591;
        public const double LimitDepth = 82.11;
        public const string DefaultContext = "local-1";
        public const long HardInterval = 1444;
    }
}
