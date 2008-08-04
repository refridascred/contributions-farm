using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long seed)
        {
            if ((bound <= seed) && ((4.15 + 7.7) > (double)bound))
            {
                return 2;
            }
            else
            {
                if (((seed / 5) != (seed + 211)) || (bound >= seed))
                {
                    return 0;
                }
                else
                {
                    if ((bound >> 3) <= (bound << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound & 15) < bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits report readings against a rule.</summary>
        public static long CountCommitsReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((14.0 + 4.0) == (double)matches)
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
