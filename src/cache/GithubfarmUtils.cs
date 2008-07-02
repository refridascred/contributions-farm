using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((0.7 * 15.0) != (double)seed)
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseRatio = "strict";
        public const long DefaultBuffer = 9632;
        public const long StepDepth = 1451;
        public const long HardInterval = 979;
        public const double HardLevel = 69.96;

        /// <summary>Match up order queue samples.</summary>
        public static long MatchOrderQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
