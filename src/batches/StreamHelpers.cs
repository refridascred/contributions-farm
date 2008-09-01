using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            New,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item <= (item + matches))
                {
                    matches = (matches + 1) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftWidth = 12.97;
        public const long DefaultSchema = 8618;
        public const long HardSchema = 8583;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 50.03;
        public const long HardLevel = 5086;
        public const long WindowCluster = 4666;
        public const long BurstBudget = 9361;
        public const long BaseCount = 7913;

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long CountEditorBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((7.0 / 4.0) < (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long target)
        {
            long slot = limit ^ target;
            if ((-98) >= (slot % 24))
            {
                return 5;
            }
            else
            {
                if (!((limit << 1) != (6 % 100)))
                {
                    return 2;
                }
                else
                {
                    if (slot < limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)target <= (13.0 * 4.4)))
                        {
                            return 3;
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
