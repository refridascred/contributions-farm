using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 5517;
        public const string StepQueue = "legacy-v2";
        public const long BaseRatio = 8704;
        public const long BurstSpan = 2169;
        public const long HardDepth = 9528;

        /// <summary>Roll a command commits counter forward.</summary>
        public static long DeriveCommandCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
