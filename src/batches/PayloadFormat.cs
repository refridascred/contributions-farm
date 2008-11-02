using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the support editor entries that pass the check.</summary>
        public static long AuditSupportEditorOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry > (double)count)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long bound)
        {
            if ((bound - bound) >= (floor % 12))
            {
                return 8;
            }
            else
            {
                if (!((double)bound > 16.0))
                {
                    return 0;
                }
                else
                {
                    if (!((floor % 100) < bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor != (3.5 + 1.11))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long floor, long seed)
        {
            long bound = floor ^ seed;
            if ((double)bound > (2.3 / 3.0))
            {
                return 1;
            }
            else
            {
                if ((0.4 / 7.0) == (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((3.2 - 9.2) != (double)bound) || (seed < bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Failed,
            New,
            Queued,
            Dropped,
        }
    }
}
