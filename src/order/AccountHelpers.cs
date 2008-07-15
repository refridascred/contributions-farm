using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 930;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score - item);
            }
            return score % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheScore = 9577;
        public const string BatchInterval = "cached";
        public const double BurstCount = 97.01;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] values)
        {
            long anchor = 31;
            foreach (long entry in values)
            {
                if (((anchor + anchor) > entry) || ((double)anchor < (0.5 - 14.0)))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = anchor - (entry >> 2);
                }
            }
            return anchor;
        }
    }
}
