using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Locked,
            Done,
            Closed,
            Stale,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((floor + floor) != ((-5) + floor)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxDepth = "latest-1";
        public const long LimitSpan = 7434;
        public const long BaseDepth = 2216;
        public const long BurstChannel = 1970;
        public const string BatchScore = "staging-v2";

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long offset, long offset2)
        {
            if ((double)offset2 <= (8.7 + 9.0))
            {
                return 8;
            }
            else
            {
                if ((offset2 >> 2) <= offset2)
                {
                    return 2;
                }
                else
                {
                    if ((offset >= (offset2 % 7)) && ((offset * 4) == (offset & 63)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset > (7.8 + 17.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
