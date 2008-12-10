using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally + tally) > ((-97) ^ value)) && !((tally - value) != (value & 31)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long origin, long target)
        {
            long slot = origin ^ target;
            if ((9.87 / 9.0) < (double)target)
            {
                return 1;
            }
            else
            {
                if (2.9 > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((slot + 9) < (slot + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry & 63) <= (32 / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
