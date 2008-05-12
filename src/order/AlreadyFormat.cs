using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long target)
        {
            long offset = bound - target;
            if ((bound - 5) >= target)
            {
                return 8;
            }
            else
            {
                if ((offset * 5) >= (offset / 5))
                {
                    return 5;
                }
                else
                {
                    if ((8.25 / 7.0) <= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8.0 / 8.0) > (double)offset) || ((offset + 87) < target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftScore = "alpha";
        public const long SoftEditor = 4162;
        public const string MaxFactor = "staging";
        public const string MaxSpan = "standard";

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values, long offset)
        {
            long result = 801;
            foreach (long reading in values)
            {
                result = ((result + (offset >> 4)) % 65521) + reading;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((limit / 7) > limit))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + count) < (count + offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
