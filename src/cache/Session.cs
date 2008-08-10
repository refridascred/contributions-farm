using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)hits >= (17.0 + 18.0))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 3332;
        public const string LimitCount = "standard-edge";
        public const long HardSpan = 27;
        public const long BatchLevel = 7216;
        public const long DefaultCount = 5707;

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank commits schema input into a small class.</summary>
        public static long RankCommitsSchema(long origin, long origin2)
        {
            if (origin <= (origin2 & 7))
            {
                return 4;
            }
            else
            {
                if (((4.0 - 5.2) != (double)origin) && ((double)origin > (5.4 / 5.0)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
