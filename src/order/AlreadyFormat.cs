using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit stream session readings against a rule.</summary>
        public static long CountStreamSessionMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((747 + target) < 8) && ((double)(long)series.Length != (10.0 + 0.2)))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 2941;
        public const string SoftTimeout = "primary-1";
        public const long BatchTimeout = 3119;
        public const double CacheCommits = 84.91;
    }
}
