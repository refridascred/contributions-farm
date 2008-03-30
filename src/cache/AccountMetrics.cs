using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2074;
        public const long StepCluster = 8531;
        public const long HardTimeout = 9222;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Grade a record commits value against two limits.</summary>
        public static long BucketRecordCommits(long seed, long step)
        {
            long next = seed ^ step;
            if (next > seed)
            {
                return 6;
            }
            else
            {
                if (!((19.0 / 7.0) >= (double)step))
                {
                    return 1;
                }
                else
                {
                    if ((step > next) || ((805 + next) < (seed & 255)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >= (977 - seed)) && ((7.2 - 14.0) < (double)step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm already entries.</summary>
        public static long DigestFarmAlready(long[] levels)
        {
            long acc = 594;
            foreach (long item in levels)
            {
                acc = ((acc ^ 2) % 65521) + item;
            }
            return acc;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long anchor = 861;
            foreach (long reading in levels)
            {
                if ((74 % 97) != (reading + reading))
                {
                    anchor = (anchor ^ reading) % 4096;
                }
            }
            if (anchor > 51)
            {
                anchor = (anchor + ((long)levels.Length - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many order window samples are out of range.</summary>
        public static long CountOrderWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((202 & 63) > (datum + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
