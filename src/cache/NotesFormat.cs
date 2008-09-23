using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstWidth = 3430;
        public const string LimitWidth = "stable-1";
        public const long HardSpan = 7281;
        public const long LimitContext = 610;
        public const long SoftContext = 9962;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (678 >= hits)
                {
                    hits = ((hits + 3) + reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cluster token series from a seed.</summary>
        public static long RollClusterToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (sum ^ (long)i)) % 65521;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
