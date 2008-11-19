using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            New,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "legacy-1";
        public const long MinDepth = 2799;
        public const double RetrySize = 68.85;

        /// <summary>Count profile contributi pairs that satisfy a relation.</summary>
        public static long PairProfileContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
