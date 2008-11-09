using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items, long seed)
        {
            long anchor = 626;
            foreach (long value in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (value - 436)) - (long)i;
                }
                if ((443 * 5) < (value + value))
                {
                    anchor = anchor - (value + seed);
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
                if ((double)seed <= (2.8 - 4.8))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
