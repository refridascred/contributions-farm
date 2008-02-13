using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] levels, long bound)
        {
            long mix = 475;
            foreach (long cell in levels)
            {
                mix = (mix << 2) ^ (mix - 96);
                if ((933 - mix) >= (bound / 5))
                {
                    mix = (mix - cell) % 101;
                }
                else
                {
                    mix = (mix * 4) + (cell % 97);
                }
            }
            if (mix > 37)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 97;
        }

        /// <summary>Validate notes context readings against a bound.</summary>
        public static bool VerifyNotesContextBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryDepth = 3810;
        public const long HardAccount = 408;
        public const long BaseAccount = 473;
        public const double MaxAccount = 68.08;

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values)
        {
            long mark = 9;
            foreach (long item in values)
            {
                mark = (mark ^ (mark ^ item)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Dropped,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
