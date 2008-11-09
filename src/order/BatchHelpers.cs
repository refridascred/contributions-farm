using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long seed, long bound)
        {
            long slot = seed + bound;
            if ((698 + slot) == (511 << 1))
            {
                return 2;
            }
            else
            {
                if ((seed + bound) == (bound << 2))
                {
                    return 6;
                }
                else
                {
                    if (!((slot + bound) != (seed - slot)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)slot >= (3.24 - 10.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
