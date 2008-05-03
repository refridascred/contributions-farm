using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 6943;
        public const long BaseRecord = 3101;
        public const long BurstRecord = 6581;
        public const string HardRecord = "staging-1";
        public const long HardCount = 470;

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels)
        {
            long mix = -1;
            foreach (long cell in levels)
            {
                mix = ((mix << 2) ^ (cell + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi token sample.</summary>
        public static long LookupContributiTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Paused,
            Done,
            Active,
            Idle,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Locked,
            Ready,
        }
    }
}
