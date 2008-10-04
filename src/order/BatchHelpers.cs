using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long step)
        {
            if ((8.0 > (double)step) && (target <= (11 % 3)))
            {
                return 4;
            }
            else
            {
                if ((target + target) <= step)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
