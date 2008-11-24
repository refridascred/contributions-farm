using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally == (1.73 + 12.0))
                {
                    tally = ((tally + 2) + cell) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long bound)
        {
            if ((origin <= (origin & 3)) || ((bound % 24) != (origin - origin)))
            {
                return 4;
            }
            else
            {
                if (44 < (bound % 64))
                {
                    return 7;
                }
                else
                {
                    if (!((origin & 31) <= origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)origin <= (2.3 - 14.0)) && ((origin / 4) < bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data, long target)
        {
            long anchor = 56;
            foreach (long sample in data)
            {
                if ((sample + anchor) < (target >> 3))
                {
                    anchor = ((anchor * 2) + (460 >> 3)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Validate buffer cluster readings against a bound.</summary>
        public static bool VerifyBufferClusterRange(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
