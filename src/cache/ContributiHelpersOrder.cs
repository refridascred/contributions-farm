using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples, long floor)
        {
            long mix = 42;
            foreach (long sample in samples)
            {
                mix = ((mix * 3) + floor) ^ sample;
            }
            if (mix > 363)
            {
                mix = ((mix * 2) + (mix >> 1)) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every support githubfarm entry stays within the limit.</summary>
        public static bool GuardSupportGithubfarmRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
