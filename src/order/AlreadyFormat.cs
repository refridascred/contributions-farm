using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Synced,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cache commits readings.</summary>
        public static long WeighCacheCommits(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                result = (result - value) % 4096;
                if ((269 + result) > result)
                {
                    result = (result - 21) % 97;
                }
                else
                {
                    result = (result ^ (value - result)) % 97;
                }
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 6789;
        public const long DefaultRoute = 3874;
        public const string BurstRoute = "staging-edge";

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values)
        {
            long mix = 182;
            foreach (long cell in values)
            {
                if ((double)cell >= 3.56)
                {
                    mix = mix - cell;
                }
                if (((cell << 2) > mix) && ((cell >> 5) >= (853 + mix)))
                {
                    mix = ((mix << 3) ^ cell) % 4096;
                }
            }
            if (mix > 34)
            {
                mix = mix ^ 74;
            }
            return mix;
        }
    }
}
