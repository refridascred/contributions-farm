using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long target, long limit)
        {
            long cur = target + limit;
            if ((cur / 7) > (target - limit))
            {
                return 2;
            }
            else
            {
                if (((double)limit < (6.38 * 14.0)) && (4.36 <= (double)target))
                {
                    return 7;
                }
                else
                {
                    if (!((target + 218) >= (cur + cur)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (cur < (target % 2))
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 38.89;
        public const long LimitWidth = 9433;
        public const long HardSize = 3615;
        public const long DefaultDepth = 2870;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + ((long)i + carry)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 6031;
        public const string DefaultNotes = "strict-edge";
        public const long MinInterval = 7822;
        public const string MaxNotes = "local-edge";
        public const double MaxTimeout = 19.89;

        /// <summary>Measure how many batch payload samples are out of range.</summary>
        public static long TallyBatchPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((123 >> 5) >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
        }
    }
}
